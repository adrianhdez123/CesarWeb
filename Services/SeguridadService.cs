namespace CesarWeb.Services

{



    public class SeguridadService : ISeguridadService<int>

    {

        // para que no pase y brinque numeros

        static string ABECEDARIO = ("'A'BCDEFGHIJKLMNÑOPQRSTUVWXYZABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        static string abecedario= ("'z'yxwvutsrqpoñnmlkjihgfedcbazyxwvutsrqpoñnmlkjihgfedcba");



        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje

        public string DesEncriptar(string Mensaje, int clave)

        {

            int r=0;

            int ar=0;

            string igualar=Mensaje;

            for(r=0;r<Mensaje.Length;r++){

                for(ar=0;ar<=52;ar++){

                    //  mayusculas

                    if(Mensaje[r]==ABECEDARIO[ar]){

                        igualar=igualar.Replace(igualar[r],ABECEDARIO[ar-clave]);

                    }

                    // minusculas

                    if(Mensaje[r]==abecedario[ar]){

                        igualar=igualar.Replace(igualar[r],abecedario[ar-clave]);

                    }

                }

            }

            Mensaje=igualar;

            return Mensaje;

        }



        

        

        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje

        public string Encriptar(string Mensaje, int clave)

    {

            int rober=0;

            int arian=0;

            string comparacion=Mensaje;

            for(rober=0;rober<Mensaje.Length;rober++){

                for(arian=0;arian<=52;arian++){

                    if(Mensaje[rober]==ABECEDARIO[arian]){



                        comparacion=comparacion.Replace(comparacion[rober],ABECEDARIO[arian+clave]);

                    }

                    if(Mensaje[rober]==abecedario[arian]){

                        comparacion=comparacion.Replace(comparacion[rober],abecedario[arian-clave]);

                    }

                }

            }

            Mensaje=comparacion;

            return Mensaje;

        }

    }

}