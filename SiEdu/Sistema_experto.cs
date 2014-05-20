using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiEdu
{
    class Sistema_experto
    {
        /*public void construir_base_conocimientos() 
        {
            FileStream var_file = new FileStream("..\\..\\vars_data.siedu", FileMode.Create, FileAccess.ReadWrite);
            FileStream n_file = new FileStream("..\\..\\n_data.siedu", FileMode.Create, FileAccess.ReadWrite);
            FileStream tag_file = new FileStream("..\\..\\tags_data.siedu", FileMode.Create, FileAccess.ReadWrite);
            FileStream cons_file = new FileStream("..\\..\\cons_data.siedu", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter var_writer = new BinaryWriter(var_file);
            BinaryWriter n_writer = new BinaryWriter(n_file);
            BinaryWriter tag_writer = new BinaryWriter(tag_file);
            BinaryWriter cons_writer = new BinaryWriter(cons_file);
            StringBuilder sb;
            int nv, nt, ntt = 0;
            double a, b, a1, b2, m1, m2, ba, ma, tras, traslape, dom;
            string variable, tag;
            a = b = a1 = b2 = m1 = ba = ma = m2 = 0;
            Console.WriteLine("Insertar el número de variables a utilizar");
            nv = int.Parse(Console.ReadLine());
            n_writer.Write(nv);
            Console.WriteLine("Inserte el traslape para los modelos difusos");
            traslape = double.Parse(Console.ReadLine());
            for (int i = 0; i < nv; i++)
            {
                var_writer.Write(i);
                Console.WriteLine("Escriba el nombre de la variable " + (i + 1));
                variable = Console.ReadLine();
                sb = new StringBuilder(variable);
                sb.Length = 10;
                var_writer.Write(sb.ToString());
                Console.WriteLine("Inserte el valor maximo del dominio de esta variable");
                dom = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserte el número de modelos");
                nt = int.Parse(Console.ReadLine());
                for (int j = 0; j < nt; j++) 
                {
                    tag_writer.Write(i);
                    Console.WriteLine("Inserta el nombre del modelo " + (j + 1));
                    tag = Console.ReadLine();
                    sb = new StringBuilder(tag);
                    sb.Length = 10;
                    tag_writer.Write(sb.ToString());
                    Console.WriteLine("¿Que tipo de modelo se insertará?\n1) Triangular\n2) Trapezoidal");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("Inserta el punto critico");
                            m1 = m2 = double.Parse(Console.ReadLine());
                            if (j == 0)
                            {
                                if (m1 == 0)
                                {
                                    a = m1;
                                    b = dom * 0.15;
                                    if (b >= dom)
                                        b = dom;
                                }
                                else
                                {
                                    a = 0;
                                    b = 2 * m1;
                                    if (b >= dom)
                                        b = dom;
                                }
                            }
                            else
                            {
                                tras = (ba - ma) * traslape;
                                a = ba - tras;
                                b = m2 + (m1 - a);
                                if (b >= dom)
                                    b = dom;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Inserta el primer punto critico");
                            m1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Inserta el segundo punto critico");
                            m2 = double.Parse(Console.ReadLine());
                            if (j == 0)
                            {
                                if (m1 == 0)
                                {
                                    a = m1;
                                    b = m2 + (dom * 0.15);
                                    if (b >= dom)
                                        b = dom;
                                }
                                else
                                {
                                    a = 0;
                                    b = m2 + (m1);
                                    if (b >= dom)
                                        b = dom;
                                }
                            }
                            else
                            {
                                tras = (ba - ma) * traslape;
                                a = ba - tras;
                                b = m2 + (m1 - a);
                                if (b >= dom)
                                    b = dom;
                            }
                            break;
                    }
                    tag_writer.Write(a);
                    tag_writer.Write(m1);
                    tag_writer.Write(m2);
                    tag_writer.Write(b);
                    ba = b;
                    ma = m2;
                    tag_writer.Write(0.0);
                    ntt++;
                }
            }
            n_writer.Write(ntt);
            Console.WriteLine("Inserta el nombre de salida");
            string salida = Console.ReadLine();
            Console.WriteLine("Inserta el número de etiquetas de salida");
            int nts = int.Parse(Console.ReadLine());
            n_writer.Write(nts);
            sb = new StringBuilder(salida);
            sb.Length = 10;
            cons_writer.Write(sb.ToString());
            Console.WriteLine("¿Cual es el valor máximo de dominio?");
            dom = int.Parse(Console.ReadLine());
            for (int i = 0; i < nts; i++)
            {
                Console.WriteLine("Inserta etiqueta de salida " + (i + 1));
                string sal = Console.ReadLine();
                sb = new StringBuilder(sal);
                sb.Length = 10;
                cons_writer.Write(sb.ToString());
                Console.WriteLine("¿Es función triangular? 1) Si, 2) No");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Inserta el punto critico");
                        m1 = m2 = double.Parse(Console.ReadLine());
                        if (i == 0)
                        {
                            if (m1 == 0)
                            {
                                a = m1;
                                b = b2 * 0.10;
                                if (b >= dom)
                                    b = dom;
                            }
                            else
                            {
                                a = 0;
                                b = 2 * m1;
                                if (b >= dom)
                                    b = dom;
                            }
                        }
                        else
                        {
                            tras = (ba - ma) * traslape;
                            a = ba - tras;
                            b = m2 + (m1 - a);
                            if (b >= dom)
                                b = dom;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Inserta el primer punto critico");
                        m1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Inserta el segundo punto critico");
                        m2 = double.Parse(Console.ReadLine());
                        if (i == 0)
                        {
                            if (m1 == 0)
                            {
                                a = m1;
                                b = m2 + (b2 * 0.10);
                                if (b >= dom)
                                    b = dom;
                            }
                            else
                            {
                                a = 0;
                                b = m2 + (m1);
                                if (b >= dom)
                                    b = dom;
                            }
                        }
                        else
                        {
                            tras = (ba - ma) * traslape;
                            a = ba - tras;
                            b = m2 + (m1 - a);
                            if (b >= dom)
                                b = dom;
                        }
                        break;
                }
                cons_writer.Write(a);
                cons_writer.Write(m1);
                cons_writer.Write(m2);
                cons_writer.Write(b);
                ba = b;
                ma = m2;

            }
            var_writer.Close();
            tag_writer.Close();
            cons_writer.Close();
            n_writer.Close();
            var_file.Close();
            tag_file.Close();
            cons_file.Close();
            n_file.Close();
        }
        public void leer_archivos() 
        {
            FileStream var_file = new FileStream("..\\..\\vars_data.siedu", FileMode.Open, FileAccess.Read);
            FileStream n_file = new FileStream("..\\..\\n_data.siedu", FileMode.Open, FileAccess.Read);
            FileStream tag_file = new FileStream("..\\..\\tags_data.siedu", FileMode.Open, FileAccess.Read);
            FileStream cons_file = new FileStream("..\\..\\cons_data.siedu", FileMode.Open, FileAccess.Read);
            BinaryReader var_reader = new BinaryReader(var_file);
            BinaryReader n_reader = new BinaryReader(n_file);
            BinaryReader tag_reader = new BinaryReader(tag_file);
            BinaryReader cons_reader = new BinaryReader(cons_file);
            int n_var, n_tag, n_cons;
            n_var = n_reader.ReadInt32();
            n_tag = n_reader.ReadInt32();
            n_cons = n_reader.ReadInt32();
            for (int i = 0; i < n_var; i++)
            {
                Console.WriteLine(var_reader.ReadInt32() + " -> " + var_reader.ReadString());
            }
            var_reader.Close();
            var_file.Close();
            for (int i = 0; i < n_tag; i++)
            {
                Console.WriteLine(tag_reader.ReadInt32() + " -> " + tag_reader.ReadString() + " | " + tag_reader.ReadDouble() + " - " + tag_reader.ReadDouble() + " - " + tag_reader.ReadDouble() + " - " + tag_reader.ReadDouble() + " - " + tag_reader.ReadDouble());
            }
            tag_reader.Close();
            tag_file.Close();
            Console.WriteLine("Salida -> " + cons_reader.ReadString());
            for (int i = 0; i < n_cons; i++)
            {
                Console.WriteLine(cons_reader.ReadString() + " -> " + cons_reader.ReadDouble() + " - " + cons_reader.ReadDouble() + " - " + cons_reader.ReadDouble() + " - " + cons_reader.ReadDouble());
            }
            Console.ReadLine();
        }
        */
        public void difusificacion() 
        {
            FileStream vars_file = new FileStream("data\\vars_data.siedu", FileMode.Open, FileAccess.Read);
            FileStream n_file = new FileStream("data\\n_data.siedu", FileMode.Open, FileAccess.Read);
            FileStream tags_file = new FileStream("data\\tags_data.siedu", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader n_reader = new BinaryReader(n_file);
            BinaryReader vars_reader = new BinaryReader(vars_file);
            BinaryReader tags_reader = new BinaryReader(tags_file);
            BinaryWriter tags_writer = new BinaryWriter(tags_file);
            formulas f = new formulas();
            double a, m1, m2, b, x;
            long nv = n_reader.ReadInt32();
            long nt = n_reader.ReadInt32();
            int kv, kt;
            string var_name, tag_name;
            n_reader.Close();
            Console.WriteLine(nv + " " + nt);
            for (int i = 0; i < nv; i++)
            {
                kv = vars_reader.ReadInt32();
                var_name = vars_reader.ReadString();
                Console.WriteLine("Inserta valor para la variable " + kv + " " + var_name);
                double temp = double.Parse(Console.ReadLine());
                tags_file.Seek(0, SeekOrigin.Begin);
                for (int j = 0; j < nt; j++)
                {
                    kt = tags_reader.ReadInt32();
                    tag_name = tags_reader.ReadString();
                    a = tags_reader.ReadDouble();
                    m1 = tags_reader.ReadDouble();
                    m2 = tags_reader.ReadDouble();
                    b = tags_reader.ReadDouble();
                    if (kv == kt)
                    {
                        if (m1 == m2)
                        {
                            if (temp >= a && temp <= m1)
                                x = f.f1(temp, a, m1);
                            else if (temp >= m2 && temp <= b)
                                x = f.f2(temp, b, m2);
                            else
                                x = 0;
                            tags_writer.Write(x);
                        }
                        else
                        {
                            if (temp > a && temp < m1)
                                x = f.f1(temp, a, m1);
                            else if (temp >= m1 && temp <= m2)
                                x = 1;
                            else if (temp >= m2 && temp <= b)
                                x = f.f2(temp, b, m2);
                            else
                                x = 0;
                            tags_writer.Write(x);
                        }
                    }
                    else
                    {
                        tags_file.Seek(tags_file.Position + 8, SeekOrigin.Begin);
                    }
                }
            }
            vars_file.Close();
            tags_file.Close();
        }
        public void leer_fam() 
        {
            StringBuilder sb;
            string text;
            int n;
            FileStream fam_ant = new FileStream("data\\FAM_ANT.siedu", FileMode.Create, FileAccess.ReadWrite);
            FileStream fam_cons = new FileStream("data\\FAM_CONS.siedu", FileMode.Create, FileAccess.ReadWrite);
            FileStream tags = new FileStream("data\\tags_data.siedu", FileMode.Open, FileAccess.Read);
            FileStream fam_a = new FileStream("data\\FAM_A.txt", FileMode.Open, FileAccess.Read);
            FileStream fam_c = new FileStream("data\\FAM_C.txt", FileMode.Open, FileAccess.Read);
            FileStream n_file = new FileStream("data\\n_data.siedu", FileMode.Open, FileAccess.Read);
            BinaryWriter fam_ant_writer = new BinaryWriter(fam_ant);
            BinaryWriter fam_cons_writer = new BinaryWriter(fam_cons);
            BinaryReader tags_reader = new BinaryReader(tags);
            StreamReader fam_a_reader = new StreamReader(fam_a);
            StreamReader fam_c_reader = new StreamReader(fam_c);
            BinaryReader n_reader = new BinaryReader(n_file);
            n_reader.ReadInt32();
            int nt = n_reader.ReadInt32();
            n_reader.Close();
            n_file.Close();
            int nr = 0;
            string line; n = 0;
            while ((line = fam_a_reader.ReadLine()) != null)
            {
                string[] rules = line.Split(' ');
                foreach (string s in rules)
                {
                    nr++;
                    sb = new StringBuilder(s);
                    sb.Length = 10;
                    fam_ant_writer.Write(n);
                    fam_ant_writer.Write(sb.ToString());
                    for (int i = 0; i < nt; i++)
                    {
                        tags_reader.ReadInt32();
                        string etiq = tags_reader.ReadString();
                        if (etiq.Equals(sb.ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            
                            tags.Seek(32, SeekOrigin.Current);
                            double valor = tags_reader.ReadDouble();
                            fam_ant_writer.Write(valor);
                            Console.WriteLine(n + " - " + sb.ToString() + " - " + valor);
                        }
                        else
                        {
                            tags.Seek(40, SeekOrigin.Current);
                        }
                    }
                    tags.Seek(0, SeekOrigin.Begin);
                }
                n++;
                text = fam_c_reader.ReadLine();
                sb = new StringBuilder(text);
                sb.Length = 10;
                fam_cons_writer.Write(sb.ToString());
                fam_cons_writer.Write((double)0.0);
            }
            fam_ant.Close();
            fam_cons.Close();
            tags.Close();
            fam_a.Close();
            fam_c.Close();
            Console.WriteLine(nr);
        }

        public void inferir() 
        {
            long n;
            FileStream fam_a_file = new FileStream("data\\FAM_ANT.siedu", FileMode.Open, FileAccess.Read);
            FileStream fam_c_file = new FileStream("data\\FAM_CONS.siedu", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader fam_a_reader = new BinaryReader(fam_a_file);
            BinaryReader fam_c_reader = new BinaryReader(fam_c_file);
            BinaryWriter fam_c_writer = new BinaryWriter(fam_c_file);
            fam_a_reader.ReadInt32();
            fam_a_reader.ReadString();
            fam_a_reader.ReadDouble();
            fam_c_reader.ReadString();
            fam_c_reader.ReadDouble();
            long tr = fam_c_file.Position;
            int n2 = (int)(fam_c_file.Length / tr);
            n = (long)(fam_a_file.Length / fam_a_file.Position);
            int index, j = 0;
            double pert, min = 1;
            fam_a_file.Seek(0, SeekOrigin.Begin);
            fam_c_file.Seek(0, SeekOrigin.Begin);
            do
            {
                for (int i = 0; i < n; i++)
                {
                    index = fam_a_reader.ReadInt32();
                    Console.Write(index + " - " + fam_a_reader.ReadString() + " - ");
                    pert = fam_a_reader.ReadDouble();
                    Console.WriteLine(pert + " | ");
                    if (index == j)
                    {
                        if (pert < min)
                            min = pert;
                    }
                }
                fam_c_file.Seek((j * tr), SeekOrigin.Begin);
                fam_c_reader.ReadString();
                fam_c_writer.Write(min);
                fam_a_file.Seek(0, SeekOrigin.Begin);
                min = 1;
                j++;
            } while (j < n2);
            fam_a_file.Close();
            fam_c_file.Close();
        }
        public void desdifusificar() 
        {
            FileStream fam_c_file = new FileStream("data\\FAM_CONS.siedu", FileMode.Open, FileAccess.Read);
            FileStream cons_file = new FileStream("data\\cons_data.siedu", FileMode.Open, FileAccess.Read);
            FileStream n_file = new FileStream("data\\n_data.siedu", FileMode.Open, FileAccess.Read);
            BinaryReader fam_c_reader = new BinaryReader(fam_c_file);
            BinaryReader cons_reader = new BinaryReader(cons_file);
            BinaryReader n_reader = new BinaryReader(n_file);
            double[] a, m1, m2, b, s2t, membresia;
            double at, m1t, m2t, bt, memb = 0.0, mbTemp = 0.0, s1t;
            formulas f = new formulas();
            string etiq, etTemp;
            fam_c_reader.ReadString();
            fam_c_reader.ReadDouble();
            long tr = fam_c_file.Position;
            int nc = (int)(fam_c_file.Length / tr);
            cons_reader.ReadString();
            long tempp = cons_file.Position;
            cons_reader.ReadString(); cons_reader.ReadDouble(); cons_reader.ReadDouble(); cons_reader.ReadDouble(); cons_reader.ReadDouble();
            long trcons = cons_file.Position - tempp;
            n_reader.ReadInt32(); n_reader.ReadInt32();
            int ncons = n_reader.ReadInt32();
            a = new double[ncons];
            m1 = new double[ncons];
            m2 = new double[ncons];
            b = new double[ncons];
            s2t = new double[ncons];
            membresia = new double[ncons];
            fam_c_file.Seek(0, SeekOrigin.Begin);
            double s1 = 0.0, s2 = 0.0;
            double max = 0, min = 0;
            for (int i = 0; i < ncons; i++)
            {
                cons_file.Seek(((i * trcons) + tempp), SeekOrigin.Begin);
                etiq = cons_reader.ReadString();
                at = cons_reader.ReadDouble();
                m1t = cons_reader.ReadDouble();
                m2t = cons_reader.ReadDouble();
                bt = cons_reader.ReadDouble();
                for (int j = 0; j < nc; j++)
                {
                    fam_c_file.Seek((j * tr), SeekOrigin.Begin);
                    etTemp = fam_c_reader.ReadString();
                    if (etiq.Equals(etTemp, StringComparison.OrdinalIgnoreCase))
                    {
                        mbTemp = fam_c_reader.ReadDouble();
                        if (mbTemp >= memb)
                            memb = mbTemp;
                    }
                }
                a[i] = at; m1[i] = m1t; m2[i] = m2t; b[i] = bt; membresia[i] = memb; 
                if (i == 0)
                    min = at;
                max = bt;
            }
            Console.WriteLine("Insertar valor de avance");
            double avance = double.Parse(Console.ReadLine());
            for (double i = min; i < max; i = i + avance) 
            {
                for (int j = 0; j < ncons; j++)
                {
                    if (i < m1[j]) 
                    {
                        s2t[j] = f.f1(i, a[j], m1[j]);
                    }
                    else if (i > m1[j] && i < m2[j]) 
                    {
                        s2t[j] = membresia[j];
                    }
                    else if (i > m2[j])
                    {
                        s2t[j] = f.f2(i, b[j], m2[j]);
                    }
                }
                s1t = obtenerMayor(s2t, membresia);
                s1 += i * s1t;
                s2 += s1t;
                s2t = new double[ncons];
            }
            Console.WriteLine("Salida Real -> " + (s1 / s2));
            Console.ReadLine();
        }
        public double obtenerMayor(double[] resultados, double[] membresia)
        {
            double mayor = 0.0;
            for (int i = 0; i < resultados.Length; i++)
            {
                if (mayor < resultados[i])
                    mayor = resultados[i];
                if (mayor > membresia[i])
                    mayor = membresia[i];
            }
            return mayor;
        }
    }
}