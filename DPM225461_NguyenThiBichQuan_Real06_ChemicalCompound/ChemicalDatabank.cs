using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real06_ChemicalCompound
{
    public  class ChemicalDatabank
    {
        public float GetCriticalPoint(string compound, string point)
        {
            if (point == "M")
            {
                switch(compound.ToLower())
                {
                    case "water":
                        return 0.0f;
                    case "benzene":
                        return 5.5f;
                    case "alcohol":
                        return -114.1f;
                    default:
                        return 0f;
                }
            }
            else
            {
                switch(compound.ToLower())
                {
                    case "water":
                        return 100.0f;
                    case "benzene":
                        return 80.1f;
                    case "alcohol":
                        return 78.3f;
                    default:
                        return 0f;
                }
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch(compound.ToLower())
            {
                case "water":
                    return "H2O";
                case "benzene":
                    return "C6H6";
                case "alcohol":
                    return "C2H6O2";
                default:
                    return "";
            }
        }

        public double GetMolecularWeight(string compound)
        {
            switch(compound.ToLower())
            {
                case "water":
                    return 18.0152;
                case "benzene":
                    return 78.1134;
                case "alcohol":
                    return 46.0688;
                default:
                    return 0d;
            }
        }

    }
}
