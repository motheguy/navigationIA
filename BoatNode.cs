﻿using System;
using System.Collections.Generic;
using System.Text;

namespace projet
{
    class BoatNode : GenericNode
    {
        public double x;
        public double y;

        public override double CalculeHCost()
        {
            throw new NotImplementedException();
        }

        public override bool EndState()
        {
            return (x==MainForm.Xf && y==MainForm.Yf);
        }

        public override double GetArcCost(GenericNode N2)
        {
            BoatNode N2bis = (BoatNode)N2;
            return time_estimation(x,y,N2bis.x,N2bis.y);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> successeur = new List<GenericNode>();
            BoatNode b1 = new BoatNode();
            b1.x = x - 2;
            b1.y = y;
            BoatNode b2 = new BoatNode();
            b2.x = x + 2;
            b2.y = y;
            BoatNode b3 = new BoatNode();
            b3.x = x + 1;
            b3.y = y-1.5;
            BoatNode b4 = new BoatNode();
            b4.x = x-1;
            b4.y = y-1.5;
            BoatNode b5 = new BoatNode();
            b5.x = x-1;
            b5.y = y+1.5;
            BoatNode b6 = new BoatNode();
            b6.x = x+1;
            b6.y = y+1.5;

            throw new NotImplementedException();


            //definir le voisinage, pavage hexagonal de 3px de diamètre
        }

        public override bool IsEqual(GenericNode N2)
        {
            BoatNode N2bis = (BoatNode)N2;
            return (x==N2bis.x && y==N2bis.y);
        }

        //Code de Salotti
        public char cas = 'a'; // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur
        public double get_wind_speed(double x, double y)
        {
            if (cas == 'a')
                return 50;
            else if (cas == 'b')
                if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150)
                return 50;
            else return 20;
        }
        public double get_wind_direction(double x, double y)
        {
            if (cas == 'a')
                return 30;
            else if (cas == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }
        public double time_estimation(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) alpha = 360 - alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

    }
}
