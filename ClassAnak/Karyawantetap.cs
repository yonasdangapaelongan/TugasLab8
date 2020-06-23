using System;
using System.Collections.Generic;
using System.Text;

namespace TugasLab8
{
    class Karyawantetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}