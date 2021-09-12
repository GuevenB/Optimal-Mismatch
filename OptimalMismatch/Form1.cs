using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace OptimalMismatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            rtbox_Source.Clear();
            lbl_karsilastirmaSayisi.Text = "0";
            lbl_eslesmeSayisi.Text = "0";
        }

        private void dosyaSecildi(string dosyaAdi)
        {
            rtbox_Source.ReadOnly = true;
            lbl_source.Text = "Kaynak String = " + dosyaAdi;
        }

        private void sonucGoster()
        {
            lbl_karsilastirmaSayisi.Text = c_karsilastirma.ToString();
            lbl_eslesmeSayisi.Text = c_eslesme.ToString();

            lbl_preRcSuresi.Text = preProcessTime.ToString() + " ms";
            lbl_AramaSuresi.Text = searchTime.ToString() + " ms";
            lbl_ToplamSure.Text = (preProcessTime + searchTime).ToString() + " ms";
            lbl_bulunanIndex.Text = "Bulunan Index Sayısı = " + c_bulunma;

        }

        private void formSifirla()
        {
            lbox_BulunanIndex.Items.Clear();
            tbox_Pattern.Text = "";
            rtbox_Source.Text = "";
            rtbox_Source.ReadOnly = false;

            lbl_bulunanIndex.Text = "Bulunan Indexler";
            lbl_karsilastirmaSayisi.Text = "0";
            lbl_eslesmeSayisi.Text = "0";

            lbl_preRcSuresi.Text = "0";
            lbl_AramaSuresi.Text = "0";
            lbl_ToplamSure.Text = "0";
            lbl_source.Text = "Kaynak String";

        }

        private void btn_findAll_Click(object sender, EventArgs e)
        {
            bool filled = false;
            String pattern = "";
            String source = "";


            if (string.IsNullOrEmpty(tbox_Pattern.Text) || string.IsNullOrEmpty(rtbox_Source.Text))
            {
                MessageBox.Show("Boş alanlar mevcut.");
            }
            else
            {
                filled = true;
                pattern = tbox_Pattern.Text;
                source = rtbox_Source.Text;
                lbox_BulunanIndex.Items.Clear();
            }




            if (filled == true)
            {

                try
                {




                    IList<int> indexList = Search(pattern, source);

                    for (int i = 0; i < indexList.Count; i++)
                    {
                        lbox_BulunanIndex.Items.Add(indexList[i].ToString());
                    }


                    sonucGoster();





                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }


            }





        }


        private void highlightIndex(int index)
        {
            rtbox_Source.SelectionStart = index;
            rtbox_Source.SelectionLength = tbox_Pattern.TextLength;
            rtbox_Source.Select();

        }


        private void lbox_BulunanIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_index = Convert.ToInt32(lbox_BulunanIndex.SelectedItem.ToString());

            highlightIndex(selected_index);


        }


        private void btn_DosyaAc_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dosyaAc_dialog = new OpenFileDialog();
                dosyaAc_dialog.Title = "Okunacak bir text dosyası seçin.";
                dosyaAc_dialog.Filter = "TXT Files|*.txt";
                dosyaAc_dialog.InitialDirectory = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop);



                if (dosyaAc_dialog.ShowDialog() == DialogResult.OK)
                {
                    dosyaSecildi(dosyaAc_dialog.SafeFileName);
                    StreamReader sr = new StreamReader(dosyaAc_dialog.FileName);
                    rtbox_Source.Text = sr.ReadToEnd();
                    sr.Close();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }





        #region OMRegion

        public static int c_karsilastirma = 0, c_eslesme = 0, c_bulunma = 0;


        public static double preProcessTime;
        public static double searchTime;

        /* Optimal Mismatch string matching algorithm. */
        public static int Search(string pattern, string source, int startIndex)
        {
            char[] x = pattern.ToCharArray(), y = source.ToCharArray(startIndex, source.Length - startIndex);
            int i, j, m = x.Length, n = y.Length;
            int[] adaptedGs = new int[m + 1], qsBc = new int[65536], freq = CalculateCharFreq(x, y, 65536);
            Pattern[] pat = new Pattern[m];


            

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            /* Preprocessing */
            OrderPattern(x, ref pat, freq);
            PreQsBc(x, ref qsBc);
            PreAdaptedGs(x, ref adaptedGs, pat);
            stopwatch.Stop();
            preProcessTime = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Restart();

            /* Searching */



            j = 0;
            while (j <= n - m)
            {
                i = 0;
                while (i < m && pat[i].c == y[j + pat[i].loc])
                    ++i;
                if (i >= m)
                {
                    stopwatch.Stop();
                    searchTime = stopwatch.Elapsed.TotalMilliseconds;
                    return j + startIndex;
                }

                if (j < n - m)
                    j += Math.Max(adaptedGs[i], qsBc[y[j + m]]);
                else
                    j += adaptedGs[i];
            }

            stopwatch.Stop();
            searchTime = stopwatch.Elapsed.TotalMilliseconds;
            return -1;
        }
        public static List<int> Search(string pattern, string source)
        {
            char[] x = pattern.ToCharArray(), y = source.ToCharArray();
            int i, j, m = x.Length, n = y.Length;
            int[] adaptedGs = new int[m + 1], qsBc = new int[65536], freq = CalculateCharFreq(x, y, 65536);
            Pattern[] pat = new Pattern[m];
            List<int> result = new List<int>();
            c_bulunma = 0;
            c_eslesme = -2;
            c_karsilastirma = -3;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            /* Preprocessing */
            OrderPattern(x, ref pat, freq);
            PreQsBc(x, ref qsBc);
            PreAdaptedGs(x, ref adaptedGs, pat);
            stopwatch.Stop();
            preProcessTime = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Restart();

            /* Searching */
            j = 0;
            while (j <= n - m)
            {
                c_karsilastirma++;

                i = 0;
                while (i < m && pat[i].c == y[j + pat[i].loc])
                {
                    ++i;
                    c_eslesme++;
                    c_karsilastirma++;
                }
                if (i >= m)
                {
                    stopwatch.Stop();
                    c_bulunma++;
                    stopwatch.Start();

                    result.Add(j);
                }
                if (j < n - m)
                    j += Math.Max(adaptedGs[i], qsBc[y[j + m]]);
                else
                    j += adaptedGs[i];
            }

            stopwatch.Stop();
            searchTime = stopwatch.Elapsed.TotalMilliseconds;
            return result;
        }

        /* Construct an ordered pattern from a string. */
        private static void OrderPattern(char[] x, ref Pattern[] pat, int[] freq)
        {

            for (int i = 0; i < x.Length; ++i)
            {
                Pattern ptrn = new Pattern();
                ptrn.loc = i;
                ptrn.c = x[i];
                pat[i] = ptrn;
            }

            QsortPtrn(ref pat, 0, x.Length - 1, freq);
        }

        private static void QsortPtrn(ref Pattern[] pat, int low, int n, int[] freq)
        {
            int lo = low;
            int hi = n;
            if (lo >= n)
            {
                return;
            }
            Pattern mid = pat[(lo + hi) / 2];
            while (lo < hi)
            {
                while (lo < hi && OptimalPcmp(pat[lo], mid, freq) < 0)
                {
                    lo++;
                }
                while (lo < hi && OptimalPcmp(pat[hi], mid, freq) > 0)
                {
                    hi--;
                }
                if (lo < hi)
                {
                    Pattern T = pat[lo];
                    pat[lo] = pat[hi];
                    pat[hi] = T;
                }
            }
            if (hi < lo)
            {
                int T = hi;
                hi = lo;
                lo = T;
            }
            QsortPtrn(ref pat, low, lo, freq);
            QsortPtrn(ref pat, lo == low ? lo + 1 : lo, n, freq);
        }

        /* Optimal Mismatch pattern comparison function. */
        private static int OptimalPcmp(Pattern pat1, Pattern pat2, int[] freq)
        {
            int fx;

            fx = freq[pat1.c] - freq[pat2.c];
            return (fx != 0 ? (fx > 0 ? 1 : -1) : (pat2.loc - pat1.loc));
        }

        /*
         * Find the next leftward matching shift for the first ploc pattern elements
         * after a current shift or lshift.
         */
        private static int MatchShift(char[] x, int ploc, int lshift, Pattern[] pat)
        {
            int i, j;

            for (; lshift < x.Length; ++lshift)
            {
                i = ploc;
                while (--i >= 0)
                {
                    if ((j = (pat[i].loc - lshift)) < 0)
                        continue;
                    if (pat[i].c != x[j])
                        break;
                }
                if (i < 0)
                    break;
            }
            return (lshift);
        }

        /*
         * Constructs the good-suffix shift table from an ordered string.
         */
        private static void PreAdaptedGs(char[] x, ref int[] adaptedGs, Pattern[] pat)
        {
            int lshift, i, ploc;

            adaptedGs[0] = lshift = 1;
            for (ploc = 1; ploc <= x.Length; ++ploc)
            {
                lshift = MatchShift(x, ploc, lshift, pat);
                adaptedGs[ploc] = lshift;
            }
            for (ploc = 0; ploc < x.Length; ++ploc)
            {
                lshift = adaptedGs[ploc];
                while (lshift < x.Length)
                {
                    i = pat[ploc].loc - lshift;
                    if (i < 0 || pat[ploc].c != x[i])
                        break;
                    ++lshift;
                    lshift = MatchShift(x, ploc, lshift, pat);
                }
                adaptedGs[ploc] = lshift;
            }
        }

        private static int[] CalculateCharFreq(char[] x, char[] y, int z)
        {
            int i;
            int[] freq = new int[z];
            for (i = 0; i < x.Length; i++)
                freq[x[i]]++;
            for (i = 0; i < y.Length; i++)
                freq[y[i]]++;
            return freq;
        }

        private static void PreQsBc(char[] x, ref int[] qsBc)
        {
            int i, m = x.Length;

            for (i = 0; i < qsBc.Length; ++i)
                qsBc[i] = m + 1;
            for (i = 0; i < m; ++i)
                qsBc[x[i]] = m - i;
        }

        #endregion

        private void btn_formSifirlama_Click(object sender, EventArgs e)
        {
            formSifirla();
        }




    }
}
