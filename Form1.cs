using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TORQUE_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double mass1, mass2, mass3, x1, x2, x3, y1, y2, y3, z1, z2, z3, grms1, grms2, totmass, xort, yort, zort, longp, longy, transp, transy, plongp, plongy, ptransp, ptransy;

            
            chart1.Series["Data"].Points.Clear();

            dataGridView1.Rows.Clear();

            // HESAPLAMA BOLUMU

            // kutleleri tanimla

            mass1 = Convert.ToDouble(uutmass.Text);
            mass2 = Convert.ToDouble(fmass.Text);
            mass3 = Convert.ToDouble(pmass.Text);

            // koordinatlari tanimla

            x1 = Convert.ToDouble(uutx.Text);
            y1 = Convert.ToDouble(uuty.Text);
            z1 = Convert.ToDouble(uutz.Text);
            x2 = Convert.ToDouble(fx.Text);
            y2 = Convert.ToDouble(fy.Text);
            z2 = Convert.ToDouble(fz.Text);
            x3 = Convert.ToDouble(px.Text);
            y3 = Convert.ToDouble(py.Text);
            z3 = Convert.ToDouble(pz.Text);

            // test grms seviyelerini tanimla

            grms1 = Convert.ToDouble(lgrms.Text);
            grms2 = Convert.ToDouble(tgrms.Text);

            // total mass hesapla

            totmass = mass1 + mass2 + mass3;

            // COG koordinatlari hesapla

            xort = ((mass1 * x1) + (mass2 * x2) + (mass3 * x3)) / (totmass);
            yort = ((mass1 * y1) + (mass2 * y2) + (mass3 * y3)) / (totmass);
            zort = ((mass1 * z1) + (mass2 * z2) + (mass3 * z3)) / (totmass);
            xort = Math.Round(xort, 2);
            yort = Math.Round(yort, 2);
            zort = Math.Round(zort, 2);

            // longitudinal momentleri hesapla

            longp = totmass * grms1 * 6 * zort;
            longy = totmass * grms1 * 6 * yort;

            // transversal momentleri hesapla

            transp = totmass * grms2 * 6 * zort;
            transy = totmass * grms2 * 6 * yort;

            // kapasite yüzdesi hesapla

            plongp = (longp / 2038735.984) * 100;
            plongy = (longy / 20387.35984) * 100;
            ptransp = (transp / 2038735.984) * 100;
            ptransy = (transy / 20387.35984) * 100;
            plongp = Math.Round(plongp, 2);
            plongy = Math.Round(plongy, 2);
            ptransp = Math.Round(ptransp, 2);
            ptransy = Math.Round(ptransy, 2);

            // YAZDIRMA BOLUMU

            // toplam kutle yazdir

            totalmass.Text = totmass.ToString()+"  kg";

            // ortalama koordinatlari yazdir

            cogx.Text = xort.ToString()+"  mm";
            cogy.Text = yort.ToString()+"  mm";
            cogz.Text = zort.ToString()+"  mm";

            // momentleri yazdir

            lpitch.Text = longp.ToString()+"  kgf*mm";
            lyaw.Text = longy.ToString()+"  kgf*mm";
            tpitch.Text = transp.ToString()+"  kgf*mm";
            tyaw.Text = transy.ToString()+"  kgf*mm";

            // kapasiteleri yazdir

            plpitch.Text = plongp.ToString() + " %";
            plyaw.Text = plongy.ToString() + " %";
            ptpitch.Text = ptransp.ToString() + " %";
            ptyaw.Text = ptransy.ToString() + " %";

            // eger fikstur kütlesi sifirsa, 390kg'dan toplam kutleyi cikar maksimum fikstur kutlesini ve z'deki eksen kacikligini bul ve listeye yaz.

            double m1;
            m1 = mass2;

            if (m1 == 0)
            {
                double m;
                double zex, amoment;

                


                for (m = 390 - totmass; m > 0;)
                {

                    if (longp > transp)
                    {
                        amoment = 2038735.984 - longp;
                        zex = amoment / (6 * m * grms1);
                        zex = Math.Round(zex, 2);

                       

                        chart1.Series["Data"].Points.AddXY(zex, m);

                        dataGridView1.Rows.Add(m, zex);

                    }
                    else
                    {
                        amoment = 2038735.984 - transp;
                        zex = amoment / (6 * m * grms2);
                        zex = Math.Round(zex, 2);


                        

                        dataGridView1.Rows.Add(m, zex);

                        chart1.Series["Data"].Points.AddXY(zex, m);
                    }

                    m = m - 10;

                }

            }

        }
    }
}

        