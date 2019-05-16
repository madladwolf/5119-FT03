using System;
using System.Collections.Generic;
using System.Text;

namespace _5119_FT03
{
    class Data
    {
        private int dia, mes, ano;
        private string diaSemana;
        public Hora h1 { get; set; }
        public Hora h2 { get; set; }

        public Data()
        {
            dia = 1;
            mes = 1;
            ano = 2000;
            diaSemana = "segunda";
            Hora h1 = new Hora();
        }
        public Data(int d, int m, int a, string di, int mes)
        {
            if (!SetDia(d)) dia = 1;
            if (!SetMes(m)) mes = 1;
            if (!SetAno(a)) ano = 2000;
            if (!SetDiaSem(di)) diaSemana = "Segunda-Feira";
            Hora h2 = new Hora(h1);
        }
        public Data(Data data)
        {
            Hora h1 = new Hora(data.h1);
            Hora h2 = new Hora(data.h2);
            dia = data.dia;
            mes = data.mes;
            ano = data.ano;
            diaSemana = data.diaSemana;
        }
        public bool checkBissexto(int a)
        {
            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                return true;
            return false;
        }

        public int getDia()
        {
            return dia;
        }
        public int getMes()
        {
            return mes;
        }
        public int getAno()
        {
            return ano;
        }
        public string getSemana()
        {
            return diaSemana;
        }
        public bool SetMes(int m)
        {
            if(m > 0 & m < 13)
            {
                mes = m;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetDia(int d)
        {
            if(mes == 1 | mes == 3 | mes == 5 | mes == 7 | mes == 9 | mes == 11)
            {
                if(dia > 0 & dia <= 31)
                {
                    dia = d;
                    return true;
                }
            }
            else
            {
                if(mes == 4 | mes == 6 | mes == 8| mes == 10 | mes == 12)
                {
                    if (dia > 0 & dia < 31)
                    {
                        dia = d;
                        return true;
                    }
                }
                else
                {
                    if (checkBissexto(ano)) 
                        if(dia > 0 & dia < 29) { dia = d; return true; }
                }
            }
            return false;
        }
        public bool SetAno(int n)
        {
            if(n < 2050 & n > 2000)
            {
                ano = n;
                return true;
            }
            return false;
        }
        public bool SetDiaSem(string dS)
        {
            if(dS == "segunda" || dS == "terça" || dS == "quarta" || dS == "quinta" || dS == "sexta" || dS == "sabado" || dS == "domingo")
            {
                diaSemana = dS;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "im awesome:" + ano + getMes() + dia;
        }
    }
}
