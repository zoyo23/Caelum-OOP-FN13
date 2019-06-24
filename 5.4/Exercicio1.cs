﻿namespace _5._4
{
    public class Exercicio1
    {
        //1. Qual é o valor exibido no seguinte código:
        //int total = 2;
        //for (int i = 0; i< 5; i += 1)
        //{
        //total = total* 2;
        //}
        //MessageBox.Show("O total é: " + total);
        //256
        //** 64 **
        //128
        //512

        public static void Executar() => VerificaLacoRepeticao();
        static string tituloJanela = "Capítulo 5 - Exercicio 1 - Resultado Multiplicação Laço For";

        private static void VerificaLacoRepeticao()
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            Util.MessageBoxUtil.ExibirMessageBox($"O total é: {total}", tituloJanela);
            informarRespostaCorreta();
        }

        private static void informarRespostaCorreta()
        {
            var mensagem = @"Qual é o valor exibido no seguinte código:
            int total = 2;
            for (int i = 0; i< 5; i += 1)
            {
                total = total* 2;
            }
            MessageBox.Show('O total é: ' + total);

            256
            ** 64 **
            128
            512";

            Util.MessageBoxUtil.ExibirMessageBox(mensagem, tituloJanela);
        }
    }
}


