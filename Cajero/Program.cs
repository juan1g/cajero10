﻿using System;

namespace Cajero2
{
    class Program
    {
        static void main(string[] args)
        {

            int[] caja = { 40, 60, 20, 10, };
            int[]valores = { 1000, 500, 200, 100, };
            int b1 = 0, b2 = 0, b3 = 0, b4 = 0, rt, retiro, cajero;

            for( int i=0; i<20; i++) {

                Console.Write("\nIngrese el monto del retiro");{
                    retiro = int.Parse(Console.ReadLine());
                    rt = retiro;
                    b1 = (retiro / 1000);
                   if ( retiro - (b1*valores[0]) >= 0){
                        retiro = retiro - (b1*valores[0]);
                        b2 = (retiro / 500);
                        if (retiro - (b2 * valores[1]) >= 0){
                            retiro = retiro - (b2 * valores[1]);
                            b3 = (retiro / 200);
                            if (retiro - (b3 * valores[2]) >= 0){
                                retiro = retiro - (b3 * valores[2]);
                                b4 = (retiro / 100);
                                if (retiro - (b4 * valores[3]) >= 0){
                                    retiro = retiro - (b4 * valores[3]);
                                }
                            }
                        }
                    if ((rt % 1000)== 0){
                            cajero = caja[0]*valores[0]+caja[1]*valores[1]+caja[2]*valores[2]+caja[3]*valores[3];
                            if (cajero >= retiro){
                                caja[0] = caja[0] - b1;
                                caja[1] = caja[1] - b2;
                                caja[2] = caja[2] - b3;
                                caja[3] = caja[3] - b4;
                                Console.Write("Retiro exitoso");
                            }   else
                                    Console.Write("\nSin efectivo para esta transaccion ");
                    } else
                                    Console.Write("\nfavor poner cantidad redondeada de villetes, Ejm. 100,200,500,1000 y no poner letras ");
                     
                            

                        
                    
                   
                

            }
                    Console.Write("\nBilletes en cajero: \n1000: " + (caja[0]) + "\n500 " + (caja[1]) + "\n200 " + (caja[2]) + "\n100" + (caja[3]));
                    Console.ReadKey();
}
        }
    }
}
}