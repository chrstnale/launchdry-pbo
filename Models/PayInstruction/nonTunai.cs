using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Launchdry.Models.PayInstruction

{   
    public class nonTunai
    {
        protected virtual void petunjuk_bayar()
        {
            Console.WriteLine("Masukkan Nomor Virtual account 13339872");
            Console.WriteLine("Masukkan jumlah top up Launch Wallet yang diinginkan, minimal" +
                "Rp 10.000");
            Console.WriteLine("Periksa data yang tertampil di layar. Pastikan nama merchant dan username");
            Console.WriteLine("Jika sudah yakin benar, tekan 'YA'");
        }
    }
}