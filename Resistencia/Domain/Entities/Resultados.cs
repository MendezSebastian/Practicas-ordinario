using System;
using Resistencia.Domain.Interfaces;

namespace Resistencia.Domain.Entities
{
    public class Result : Operacion
    {
        private string _B1;
        private string _B2;
        private string _B3;
        private string _B4;
        private string v1;
        private string v2;
        private string _result;
        private int valor = 0;
        public double suma = 0.0;
        private double _result2 = 0.0;
        private double _result3 = 0.0;
        private double mas = 0.0;
        private double menos =0.0;

        
        public void Banda_1(string B1)
        {
            _B1 = B1.ToLower();
            switch(B1){
                case "Negro":
                break;
                case "Cafe":
                v1 = "1";
                break;
                case "Rojo":
                v1 = "2";
                break;
                case "Naranja":
                v1 = "3";
                break;
                case "Amarillo":
                v1 = "4";
                break;
                case "Verde":
                v1 = "5";
                break;
                case "Azul":
                v1 = "6";
                break;
                case "Violeta":
                v1 = "7";
                break;
                case "Gris":
                v1 = "8";
                break;
                case "Blanco":
                v1 = "9";
                break;
                
            }
        }
        public void Banda_2(string B2)
        {
            _B2 = B2.ToLower();
            switch(B2){
                case "Negro":
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                case "Cafe":
                v2 = "1";
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                case "Rojo":
                v2 = "2";
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                case "Naranja":
                v2 = "3";
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                case "Amarillo":
                v2 = "4";
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                case "Verde":
                v2 = "5";
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                case "Azul":
                v2 = "6";
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                case "Violeta":
                v2 = "7";
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                case "Gris":
                v2 = "8";
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                case "Blanco":
                v2 = "9";
                _result = v1 + v2;
                valor = int.Parse(_result);
                break;
                
            }
        }
        public void Banda_3(string B3)
        {

            _B3 = B3.ToLower();
            switch(B3){
                case "Negro":
                _result2 = 1;
                suma = valor * _result2;
                break;
                case "Cafe":
                _result2 = 10;
                suma = valor * _result2;
                break;
                case "Rojo":
                _result2 = 100;
                suma = valor * _result2;
                break;
                case "Naranja":
                _result2 = 1000;
                suma = valor * _result2;
                break;
                case "Amarillo":
                _result2 = 10000;
                suma = valor * _result2;
                break;
                case "Verde":
                _result2 = 100000;
                suma = valor * _result2;
                break;
                case "Azul":
                _result2 = 1000000;
                suma = valor * _result2;
                break;
                case "Violeta":
                _result2 = 10000000;
                suma = valor * _result2;
                break;
                case "Gris":
                _result2 = 100000000;
                suma = valor * _result2;
                break;
                case "Blanco":
                _result2 = 1000000000;
                suma = valor * _result2;
                break;
                
            }
        }
        public void Banda_gold(string B4)
        {
            _B4 = B4.ToLower();

                if(B4 == "Dorado"){
                _result3 = suma * 0.5/10;
                }
                if(B4 == "Plata"){
                _result3 = suma * 0.10/10;
                }
             mas= suma + _result3;
         menos= suma - _result3;  
           
        }

        public string operacion()
        {
             
             return $"el valor es {suma} y la tolerancia es {_result3} El rango de toleracia si tiene mas el {_result3} es de: {mas} El rango de tolerancia si tiene menos el {_result3} es de : {menos} ";
        }

        
    }
}