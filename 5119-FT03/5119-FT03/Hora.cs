using System;
using System.Collections.Generic;
using System.Text;

namespace _5119_FT03
{
    class Hora
    {
        public int hora, min, seg;
        public Hora()
        {
            hora = 0;
            min = 0;
            seg = 0;
        }
        public Hora(int h, int m, int s)
        {
            if (!setHora(h)) hora = 0;
            if (!setMin(m)) min = 0;
            if (!setSeg(s)) seg = 0;
        }
        public Hora(Hora h)
        {
            hora = h.getHora();
            min = h.getMin();
            seg = h.getSeg();
        }


        public bool setHora(int h)
        {
            if (h > 1 & h < 23) {
                return true;
                hora = h;
            }
            else
            {
                return true;
            }
            
        }
        public bool setMin(int m)
        {
            if(m >= 0 && m < 59)
            {
                min = m;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool setSeg(int s)
        {
            if (s >= 0 && s < 60)
            {
                seg = s;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getHora()
        {
            return hora;
        }
        public int getMin()
        {
            return min;
        }
        public int getSeg()
        {
            return seg;
        }
    }
    
}
    
