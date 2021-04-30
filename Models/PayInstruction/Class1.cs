using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Launchdry.Models.PayInstruction
{
    public class petunjukBayarBCA : nonTunai
    {
        protected override void petunjuk_bayar()
        {

            Console.WriteLine("Pilih Transaksi Lainnya > Transfer > ke Rek BCA Virtual Account");
            base.petunjuk_bayar();
        }
    }

    public class petunjukBayarBRI : nonTunai
    {
        protected override void petunjuk_bayar()
        {

            Console.WriteLine("Pilih Transaksi Lainnya > Transfer > ke Rek BRI Virtual Account");
            base.petunjuk_bayar();
        }

    }

    public class petunjukBayarMandiri : nonTunai
    {
        protected override void petunjuk_bayar()
        {

            Console.WriteLine("Pilih Transaksi Lainnya > Transfer > ke Rek Mandiri Virtual Account");
            base.petunjuk_bayar();
        }

    }

    public class petunjukBayarBNI : nonTunai
    {
        protected override void petunjuk_bayar()
        {

            Console.WriteLine("Pilih Transaksi Lainnya > Transfer > ke Rek BNI Virtual Account");
            base.petunjuk_bayar();
        }

    }
}