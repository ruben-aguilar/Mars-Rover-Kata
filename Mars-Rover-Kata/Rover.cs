using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover_Kata
{
    public class Rover
    {
        private int m_X = 0;
        private int m_Y = 0;
        private char m_direction = 'N';

        public int X { get { return m_X; } }
        public int Y { get { return m_Y; } }
        public char Direction { get { return m_direction; } }

        public Rover(int x, int y, char direction)
        {
            m_X = x;
            m_Y = y;
            m_direction = direction;
        }

        public void ExecuteCommand(char command)
        {
            if (m_direction == 'N')
            {
                if (command == 'F')
                {
                    m_Y = 1;
                }
                else
                {
                    m_Y = -1;
                }
            }
            else
            {
                if (command == 'F')
                {
                    m_X = 1;
                }
                else
                {
                    m_X = -1;
                }
            }
        }
    }
}
