using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvls : MonoBehaviour
{
    public bool[,] Squares;
    private int strings;
    private int colums;

    public void ChooseLvl(string LvlNumber){
        switch (LvlNumber){
            case "Lvl1":
                Lvl1();
                break;
            case "Lvl2":
                Lvl2();
                break;
            case "Lvl3":
                Lvl3();
                break;
            case "Lvl4":
                Lvl4();
                break;
            case "Lvl5":
                Lvl5();
                break;
            case "Lvl6":
                Lvl6();
                break;
            case "Lvl7":
                Lvl7();
                break;
            case "Lvl8":
                Lvl8();
                break;
            case "Lvl9":
                Lvl9();
                break;
            case "Lvl10":
                Lvl10();
                break;
            case "Lvl11":
                Lvl11();
                break;
            case "Lvl12":
                Lvl12();
                break;
            case "Lvl13":
                Lvl13();
                break;
            case "Lvl14":
                Lvl14();
                break;
            case "Lvl15":
                Lvl15();
                break;
        }
    }

    public void Lvl1(){
        strings = 9;
        colums = 3;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }
        Squares[0,0] = true;
        Squares[0,1] = true;
        Squares[1,1] = true;
        Squares[2,1] = true;
        Squares[3,1] = true;
        Squares[4,1] = true;
        Squares[5,1] = true;
        Squares[6,1] = true;
        Squares[7,1] = true;
        Squares[8,1] = true;
        Squares[8,2] = true;
    }

    public void Lvl2(){
        strings = 5;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }
        Squares[0,0] = true;
        Squares[0,1] = true;
        Squares[0,2] = true;
        Squares[0,3] = true;
        Squares[0,4] = true;
        Squares[0,5] = true;
        Squares[0,6] = true;
        Squares[1,6] = true;
        Squares[2,6] = true;
        Squares[2,5] = true;
        Squares[2,4] = true;
        Squares[2,3] = true;
        Squares[2,2] = true;
        Squares[2,1] = true;
        Squares[2,0] = true;
        Squares[3,0] = true;
        Squares[4,0] = true;
        Squares[4,1] = true;
        Squares[4,2] = true;
        Squares[4,3] = true;
        Squares[4,4] = true;
        Squares[4,5] = true;
        Squares[4,6] = true;
    }

    public void Lvl3(){
        strings = 9;
        colums = 9;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }
        Squares[0,0] = true;
        Squares[1,0] = true;
        Squares[2,0] = true;
        Squares[2,1] = true;
        Squares[2,2] = true;
        Squares[2,3] = true;
        Squares[2,4] = true;
        Squares[2,5] = true;
        Squares[3,5] = true;
        Squares[4,5] = true;
        Squares[5,5] = true;
        Squares[6,5] = true;
        Squares[7,5] = true;
        Squares[7,6] = true;
        Squares[7,7] = true;
        Squares[8,7] = true;
        Squares[8,8] = true;
    }

    public void Lvl4(){
        strings = 7;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }
        Squares[0,0] = true;
        Squares[1,0] = true;
        for(int i=0;i<7;i++){
            Squares[1,i] = true;
        }
        Squares[2,6] = true;
        for(int i=3;i<7;i++){
            Squares[3,i] = true;
        }
        Squares[4,3] = true;
        Squares[4,2] = true;
        Squares[4,1] = true;
        Squares[5,1] = true;
        for(int i=1;i<5;i++){
            Squares[6,i] = true;
        }
    }

    public void Lvl5(){
        strings = 7;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }
        Squares[0,0] = true;
        Squares[1,0] = true;
        Squares[1,1] = true;
        Squares[2,1] = true;
        Squares[2,2] = true;
        Squares[2,3] = true;
        Squares[1,3] = true;
        Squares[1,4] = true;
        Squares[1,5] = true;
        Squares[2,5] = true;
        Squares[2,6] = true;
        Squares[3,6] = true;
        Squares[4,6] = true;
        Squares[5,6] = true;
        Squares[5,5] = true;
        Squares[6,5] = true;
        Squares[6,4] = true;
        Squares[6,3] = true;
        Squares[5,3] = true;
        Squares[4,3] = true;
        Squares[4,2] = true;
        Squares[4,1] = true;
        Squares[5,1] = true;
        Squares[6,1] = true;
    }

    public void Lvl6(){
        strings = 5;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }
        Squares[4,0] = true;
        Squares[3,0] = true;
        Squares[3,1] = true;
        Squares[3,2] = true;
        Squares[2,2] = true;
        Squares[1,2] = true;
        Squares[0,2] = true;
        Squares[0,3] = true;
        Squares[2,3] = true;
        Squares[2,4] = true;
        Squares[2,5] = true;
        Squares[2,6] = true;
        Squares[3,6] = true;
        Squares[4,6] = true;
    }

    public void Lvl7(){
        strings = 7;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }
        Squares[3,2] = true;
        Squares[3,1] = true;
        Squares[2,1] = true;
        Squares[1,1] = true;
        Squares[1,2] = true;
        Squares[1,3] = true;
        Squares[1,4] = true;
        Squares[2,4] = true;
        Squares[2,5] = true;
        Squares[3,5] = true;
        Squares[3,6] = true;
        Squares[4,6] = true;
        Squares[5,6] = true;
        Squares[5,5] = true;
        Squares[3,2] = true;
        Squares[6,5] = true;
        Squares[6,4] = true;
        Squares[6,3] = true;
        Squares[6,2] = true;
        Squares[6,1] = true;
        Squares[0,2] = true;
    }

    public void Lvl8(){
        strings = 7;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }
        Squares[0,4] = true;
        Squares[1,4] = true;
        Squares[1,3] = true;
        Squares[2,3] = true;
        Squares[2,2] = true;
        Squares[3,2] = true;
        Squares[4,2] = true;
        Squares[4,3] = true;
        Squares[4,4] = true;
        Squares[3,4] = true;
        Squares[3,5] = true;
        Squares[3,6] = true;
        Squares[4,6] = true;
        Squares[5,6] = true;
        Squares[5,5] = true;
        Squares[6,5] = true;
        Squares[4,1] = true;
        Squares[4,0] = true;
        Squares[5,0] = true;
        Squares[6,0] = true;
        Squares[6,1] = true;
        Squares[6,2] = true;
    }

    public void Lvl9(){
        strings = 7;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }
        for(int i=0;i<7;i++){
            Squares[i,3] = true;
        }
        Squares[6,2] = true;
        Squares[6,1] = true;
        Squares[5,1] = true;
        Squares[5,0] = true;
        Squares[4,0] = true;
        Squares[3,0] = true;
        Squares[3,1] = true;
        Squares[2,1] = true;
        Squares[2,2] = true;
        Squares[2,4] = true;
        Squares[2,5] = true;
        Squares[3,5] = true;
        Squares[4,5] = true;
        Squares[5,5] = true;
        Squares[5,6] = true;
    }

    public void Lvl10(){
        strings = 9;
        colums = 11;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }        
        Squares[4,5] = true;
        Squares[3,5] = true;
        Squares[2,5] = true;
        Squares[2,6] = true;
        Squares[2,7] = true;
        Squares[3,7] = true;
        Squares[4,7] = true;
        Squares[5,7] = true;
        Squares[6,7] = true;
        Squares[6,8] = true;
        Squares[6,9] = true;
        Squares[6,10] = true;
        Squares[5,10] = true;
        Squares[4,10] = true;
        Squares[4,9] = true;
        Squares[3,9] = true;
        Squares[2,9] = true;
        Squares[2,10] = true;
        Squares[1,10] = true;
        Squares[0,10] = true;
        Squares[0,9] = true;
        Squares[0,8] = true;
        Squares[0,7] = true;
        Squares[0,6] = true;
        Squares[1,6] = true;
        Squares[2,6] = true;

        Squares[6,6] = true;
        Squares[6,5] = true;
        Squares[6,4] = true;
        Squares[6,3] = true;
        Squares[5,3] = true;
        Squares[4,3] = true;
        Squares[3,3] = true;
        Squares[2,3] = true;
        Squares[1,3] = true;
        Squares[0,3] = true;
        Squares[0,2] = true;
        Squares[0,1] = true;
        
        Squares[0,1] = true;
        Squares[1,1] = true;
        Squares[2,1] = true;
        Squares[3,1] = true;
        Squares[4,1] = true;

        Squares[4,0] = true;
        Squares[5,0] = true;
        Squares[6,0] = true;
        Squares[6,1] = true;
        Squares[7,1] = true;
        Squares[7,2] = true;
        Squares[8,2] = true;
        Squares[8,3] = true;
    }

    public void Lvl11(){
        strings = 7;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = false;
            }
        }        
        Squares[5,0] = true;
        Squares[4,0] = true;
        Squares[3,0] = true;
        Squares[2,0] = true;
        Squares[1,0] = true;
        Squares[1,1] = true;
        Squares[0,1] = true;
        Squares[0,2] = true;
        Squares[0,3] = true;
        Squares[1,3] = true;
        Squares[2,3] = true;
        Squares[2,2] = true;
        Squares[3,2] = true;
        Squares[4,2] = true;
        Squares[5,2] = true;
        Squares[5,3] = true;
        Squares[6,3] = true;
        Squares[5,4] = true;
        Squares[4,4] = true;
        Squares[3,4] = true;
        Squares[3,5] = true;
        Squares[3,6] = true;
        Squares[2,6] = true;
        Squares[1,6] = true;
        Squares[1,5] = true;
        Squares[1,4] = true;
    }

    public void Lvl12(){
        strings = 7;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = true;
            }
        }        
        Squares[0,0] = false;
        Squares[6,0] = false;
        Squares[2,1] = false;
        Squares[1,2] = false;
        Squares[3,1] = false;
        Squares[4,1] = false;
        Squares[5,2] = false;
        Squares[5,3] = false;
        Squares[5,4] = false;
        Squares[5,5] = false;
        Squares[5,6] = false;
        Squares[4,5] = false;
        Squares[3,5] = false;
        Squares[1,4] = false;
        Squares[3,3] = false;
    }

    public void Lvl13(){
        strings = 11;
        colums = 11;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = true;
            }
        }        
        for(int i=1;i<strings;i=i+2){
            for(int j=1;j<colums;j=j+2){
                Squares[i,j] = false;
            }
        }
    }

    public void Lvl14(){
        strings = 13;
        colums = 7;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = true;
            }
        }        
        Squares[0,2] = false;
        Squares[0,3] = false;
        Squares[0,4] = false;
        Squares[0,5] = false;
        Squares[0,6] = false;
        Squares[1,3] = false;
        Squares[1,0] = false;
        Squares[2,0] = false;
        Squares[2,1] = false;
        Squares[2,5] = false;
        Squares[3,0] = false;
        Squares[3,1] = false;
        Squares[3,2] = false;
        Squares[3,4] = false;
        Squares[4,6] = false;
        Squares[5,1] = false;
        Squares[5,2] = false;
        Squares[5,4] = false;
        Squares[6,1] = false;
        Squares[6,2] = false;
        Squares[6,4] = false;
        Squares[6,5] = false;
        Squares[7,1] = false;
        Squares[7,2] = false;
        Squares[8,4] = false;
        Squares[8,5] = false;
        Squares[9,1] = false;
        Squares[9,5] = false;
        Squares[10,3] = false;
        Squares[11,1] = false;
        Squares[11,3] = false;
        Squares[11,4] = false;
        Squares[11,5] = false;
    }

    public void Lvl15(){
        strings = 13;
        colums = 13;
        Squares = new bool [strings,colums];
        for(int i=0;i<strings;i++){
            for(int j=0;j<colums;j++){
                Squares[i,j] = true;
            }
        }        
        Squares[0,0] = false;
        Squares[0,1] = false;
        Squares[1,0] = false;
        Squares[5,0] = false;
        Squares[6,0] = false;
        Squares[7,0] = false;
        Squares[8,0] = false;
        Squares[9,0] = false;
        Squares[10,0] = false;
        Squares[11,0] = false;
        Squares[12,0] = false;
        Squares[3,1] = false;
        Squares[6,1] = false;
        Squares[7,1] = false;
        Squares[8,1] = false;
        Squares[12,1] = false;
        Squares[2,2] = false;
        Squares[7,2] = false;
        Squares[8,2] = false;
        Squares[10,2] = false;
        Squares[12,2] = false;
        Squares[1,3] = false;
        Squares[4,3] = false;
        Squares[5,3] = false;
        Squares[10,3] = false;
        Squares[12,3] = false;
        Squares[1,4] = false;
        Squares[3,4] = false;
        Squares[4,4] = false;
        Squares[5,4] = false;
        Squares[6,4] = false;
        Squares[7,4] = false;
        Squares[8,4] = false;
        Squares[10,4] = false;
        Squares[1,5] = false;
        Squares[4,5] = false;
        Squares[8,5] = false;
        Squares[10,5] = false;
        Squares[11,5] = false;
        Squares[1,6] = false;
        Squares[2,6] = false;
        Squares[4,6] = false;
        Squares[6,6] = false;
        Squares[1,7] = false;
        Squares[2,7] = false;
        Squares[4,7] = false;
        Squares[6,7] = false;
        Squares[8,7] = false;
        Squares[10,7] = false;
        Squares[11,7] = false;
        Squares[4,8] = false;
        Squares[6,8] = false;
        Squares[7,8] = false;
        Squares[8,8] = false;
        Squares[10,8] = false;
        Squares[11,8] = false;
        Squares[0,9] = false;
        Squares[2,9] = false;
        Squares[3,9] = false;
        Squares[4,9] = false;
        Squares[10,9] = false;
        Squares[11,9] = false;
        Squares[0,11] = false;
        Squares[1,11] = false;
        Squares[3,11] = false;
        Squares[5,11] = false;
        Squares[9,11] = false;
        Squares[11,11] = false;
        Squares[12,11] = false;
        Squares[0,10] = false;
        Squares[5,10] = false;
        Squares[6,10] = false;
        Squares[8,10] = false;
        Squares[9,10] = false;
        Squares[0,12] = false;
        Squares[1,12] = false;
        Squares[7,12] = false;
        Squares[11,12] = false;
        Squares[12,12] = false;
    }
}
