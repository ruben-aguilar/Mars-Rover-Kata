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
        private const char NORTH_DIRECTION = 'N';
        private const char FORWARD_COMMAND = 'F';

        private char m_direction = NORTH_DIRECTION;

        private int m_X = 0;
        private int m_Y = 0;

        public int X => m_X;
        public int Y => m_Y;
        public char Direction => m_direction;

        public Rover(int x, int y, char direction)
        {
            m_X = x;
            m_Y = y;
            m_direction = direction;
        }

        public void ExecuteCommand(char command)
        {
            if (m_direction == NORTH_DIRECTION)
            {
                if (command == FORWARD_COMMAND)
                {
                    m_Y++;
                }
                else
                {
                    m_Y--;
                }
            }
            else
            {
                if (command == FORWARD_COMMAND)
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
