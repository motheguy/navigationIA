using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace projet
{
    class BoatNode : GenericNode
    {
        public double x;
        public double y;
        public char cas = MainForm.cas;


        //Constructeurs
        public BoatNode(double X, double Y) //avec arguments
        {
            x = X;
            y = Y;
        }

        public BoatNode() //sans argument
        {

        }

        /// <summary>
        /// Calculates a time estimation to reach the final node
        /// </summary>
        /// <returns>Time estimation between a node and the final node</returns>
        public override double CalculeHCost()
        {
            //Permet d'obtenir une estimation heuristique du cout pour atteindre le point final


            double distance = Math.Sqrt((x - MainForm.Xf) * (x - MainForm.Xf) + (y - MainForm.Yf) * (y - MainForm.Yf));
            double boatspeed = 45;
            return (distance / boatspeed);

            //double time = time_estimationH(x, y, MainForm.Xf, MainForm.Yf); //test avec un nouveau time_estimation
            //return time;
        }

        public override bool EndState()
        {
            //on considère qu'on est arrivé si on est à une distance inférieure à notre déplacement minimal
            return Math.Sqrt((x - MainForm.Xf) * (x - MainForm.Xf) + (y - MainForm.Yf) * (y - MainForm.Yf)) <= 5;
            //return (x == MainForm.Xf && y == MainForm.Yf);
        }

        /// <summary>
        /// Calculates the cost in terms of time between two nodes
        /// </summary>
        /// <param name="N2"></param>
        /// <returns>Arc Cost between this node and N2</returns>
        public override double GetArcCost(GenericNode N2) //OK a verifier
        {
            //Permet d'obtenir le cout de l'arc entre 2 noeuds
            BoatNode N2bis = (BoatNode)N2;
            double valGCostN2 = time_estimation(x, y, N2bis.x, N2bis.y); //On calcule le cout
            return valGCostN2;
        }

        /// <summary>
        /// Returns the 8 nodes adjacent to the studied node
        /// </summary>
        /// <returns>List of GenericNode</returns>
        public override List<GenericNode> GetListSucc() //OK a verifier
        {
            //on recupere les valeurs des points voisins et on les ajoute a notre liste
            //notre pavage est carre et le point considere possède 8 voisins

            List<GenericNode> successeur = new List<GenericNode>();

            //pavage de 3 : toutes les 3 cases
            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                    if (j != 0 || i != 0)
                        successeur.Add(new BoatNode((int)x + 6 * i, (int)y + 6 * j));

            //pavage de 3 et 6 : toutes les 3 cases
            /*for (int i = -2; i <= 2; i++)
                for (int j = -2; j <= 2; j++)
                    if (i != 0 || j != 0)
                        successeur.Add(new BoatNode((int)x + 3 * i, (int)y + 3 * j));
            /*
            for (int i = -1; i < 2; i ++)
            {
                BoatNode b1 = new BoatNode((int)x + i, (int)y - 1);
                successeur.Add(b1);
                BoatNode b2 = new BoatNode((int)x + i, (int)y + 1);
                successeur.Add(b2);
                if (i != -1 || i != 1)
                {
                    BoatNode b3 = new BoatNode((int)x + 1, (int)y + i);
                    successeur.Add(b3);
                    BoatNode b4 = new BoatNode((int)x - 1, (int)y + i);
                    successeur.Add(b4);
                }

            }
            */

            /*
            for (int i = -3; i < 4; i+=3)
            {
                BoatNode b1 = new BoatNode((int)x + i, (int)y - 3);
                successeur.Add(b1);
                BoatNode b2 = new BoatNode((int)x + i, (int)y + 3);
                successeur.Add(b2);
                if (i != -3 || i != 3)
                {
                    BoatNode b3 = new BoatNode((int)x + 3, (int)y + i);
                    successeur.Add(b3);
                    BoatNode b4 = new BoatNode((int)x - 3, (int)y + i);
                    successeur.Add(b4);
                }

            }

            for (int i = -6; i < 7; i += 6)
            {
                BoatNode b1 = new BoatNode((int)x + i, (int)y - 6);
                successeur.Add(b1);
                BoatNode b2 = new BoatNode((int)x + i, (int)y + 6);
                successeur.Add(b2);
                if (i != -6 || i != 6)
                {
                    BoatNode b3 = new BoatNode((int)x + 6, (int)y + i);
                    successeur.Add(b3);
                    BoatNode b4 = new BoatNode((int)x - 6, (int)y + i);
                    successeur.Add(b4);
                }
            }
            */
            /*
            for (int i = -3; i < 4; i++)
            {
                BoatNode b1 = new BoatNode((int)x + i, (int)y -3);
                successeur.Add(b1);
                BoatNode b2 = new BoatNode((int)x + i, (int)y + 3);
                successeur.Add(b2);
                if (i!=-3 || i!=3)
                {
                    BoatNode b3 = new BoatNode((int)x + 3, (int)y + i);
                    successeur.Add(b3);
                    BoatNode b4 = new BoatNode((int)x - 3, (int)y + i);
                    successeur.Add(b4);
                }                
                
            }

            for (int i = -6; i < 7; i +=6)
            {
                BoatNode b1 = new BoatNode((int)x + i, (int)y - 6);
                successeur.Add(b1);
                BoatNode b2 = new BoatNode((int)x + i, (int)y + 6);
                successeur.Add(b2);
                if (i != -6 || i != 6)
                {
                    BoatNode b3 = new BoatNode((int)x + 6, (int)y + i);
                    successeur.Add(b3);
                    BoatNode b4 = new BoatNode((int)x - 6, (int)y + i);
                    successeur.Add(b4);
                }
            }
            */

            //for(int i = -9; i < 10; i++)
            //{
            //    BoatNode b1 = new BoatNode((int)x + i, (int)y - 9);
            //    successeur.Add(b1);
            //    BoatNode b2 = new BoatNode((int)x + i, (int)y + 9);
            //    successeur.Add(b2);
            //    if (i != -9 || i != 9)
            //    {
            //        BoatNode b3 = new BoatNode((int)x + 9, (int)y + i);
            //        successeur.Add(b3);
            //        BoatNode b4 = new BoatNode((int)x - 9, (int)y + i);
            //        successeur.Add(b4);
            //    }
            //}
            //for (int i = -3; i < 4; i++)
            //{
            //    for (int j = -3; j < 4; j++)
            //    {
            //        if (i!=0 && j!=0)
            //        {
            //            BoatNode b = new BoatNode((int)x + i, (int)y + j);
            //            successeur.Add(b);
            //        }
            //    }
            //}


            //BoatNode b1 = new BoatNode((int)x + 1, (int)y);
            //successeur.Add(b1);

            //BoatNode b2 = new BoatNode((int)x - 1, (int)y);
            //successeur.Add(b2);

            //BoatNode b3 = new BoatNode((int)x, (int)y - 1);
            //successeur.Add(b3);

            //BoatNode b4 = new BoatNode((int)x + 1, (int)y - 1);
            //successeur.Add(b4);

            //BoatNode b5 = new BoatNode((int)x - 1, (int)y - 1);
            //successeur.Add(b5);

            //BoatNode b6 = new BoatNode((int)x, (int)y + 1);
            //successeur.Add(b6);

            //BoatNode b7 = new BoatNode((int)x + 1, (int)y + 1);
            //successeur.Add(b7);

            //BoatNode b8 = new BoatNode((int)x - 1, (int)y + 1);
            //successeur.Add(b8);

            //BoatNode b9 = new BoatNode((int)x - 3, (int)y -3);
            //successeur.Add(b9);

            //BoatNode b10 = new BoatNode((int)x, (int)y-3);
            //successeur.Add(b10);

            //BoatNode b11 = new BoatNode((int)x + 3 , (int)y - 3);
            //successeur.Add(b11);

            //BoatNode b12 = new BoatNode((int)x + 3 , (int)y);
            //successeur.Add(b12);

            //BoatNode b13 = new BoatNode((int)x +3 , (int)y + 3);
            //successeur.Add(b13);

            //BoatNode b14 = new BoatNode((int)x , (int)y + 3);
            //successeur.Add(b14);

            //BoatNode b15 = new BoatNode((int)x - 3, (int)y + 3);
            //successeur.Add(b15);

            //BoatNode b16 = new BoatNode((int)x-3 , (int)y );
            //successeur.Add(b16);

            return successeur;
        }

        public override bool IsEqual(GenericNode N2)
        {
            BoatNode N2bis = (BoatNode)N2;
            return (x == N2bis.x && y == N2bis.y);
        }

        public double get_wind_speed(double x, double y) //OK a verifier
        {
            //On distingue plusieurs cas en fonction de la valeur du char cas, saisi par l'utilisateur
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
        public double get_wind_direction(double x, double y) //OK a verifier
        {
            //On distingue plusieurs cas en fonction de la valeur du char cas, saisi par l'utilisateur
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
        public double time_estimation(double x1, double y1, double x2, double y2) //OK a verifier
        {
            //Etape 1 : calcul distance

            //On calcule la distance entre les 2 points
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            //cas 1 :
            if (distance > 10) return 1000000; // le point est trop loin, retourne une valeur d'arret

            //cas 2 : 

            //Etape 2 : calcul vitesse et direction du vent et du bateau

            //On calcule la vitesse et la direction du vent
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);

            //On calcule la vitesse et la direction du bateau
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;

            //Etape 3 : determination de la position du bateau relativement au vent

            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :

            //cas 1 : recalcul d'alpha
            if (alpha > 180) alpha = 360 - alpha;

            //cas 2 : entre vent arrière et largue
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }

            //cas 3 : entre largue et travers
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }

            //cas 4 : entre travers et près jusqu'a 150°
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }

            //cas 5 : alpha sup a 150° et inf a 180°, la vitesse est nulle, le bateau ne peut plus avance
            else
                return 1000000; //envoi valeur d'arret
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

        public double time_estimationH(double x1, double y1, double x2, double y2) //OK a verifier
        {
            //Etape 1 : calcul distance

            //On calcule la distance entre les 2 points
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            //cas 1 :
            //if (distance > 10) return 1000000; // le point est trop loin, retourne une valeur d'arret

            //cas 2 : 

            //Etape 2 : calcul vitesse et direction du vent et du bateau

            //On calcule la vitesse et la direction du vent
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);

            //On calcule la vitesse et la direction du bateau
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;

            //Etape 3 : determination de la position du bateau relativement au vent

            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :

            //cas 1 : recalcul d'alpha
            if (alpha > 180) alpha = 360 - alpha;

            //cas 2 : entre vent arrière et largue
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }

            //cas 3 : entre largue et travers
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }

            //cas 4 : entre travers et près jusqu'a 150°
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }

            //cas 5 : alpha sup a 150° et inf a 180°, la vitesse est nulle, le bateau ne peut plus avance
            else
                return 1000000; //envoi valeur d'arret
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

    }
}
