using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        string betöltendő_pálya = "palya001.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 10, 10, 10, 10, 0, 1, 1, 2);


            Robot janesz = new Robot("Janesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 15, 3, 29, 0);

            janesz.Feladat = delegate ()
            {
                int a = 0;
                a = janesz.UltrahangSzenzor();
                for (int i = 0; i < janesz.Köveinek_száma_ebből(hó); i++)
                {
                    janesz.Lőjj();
                    for (int j = 0; j < 5; j++)
                    {
                        janesz.Várj();
                        a = janesz.UltrahangSzenzor();
                    }

                }
            };

        }
    }
}
