using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Image ObjectwitchImage;
    public Image ObjectwitchImage00;
    public Image ObjectwitchImage10;
    public Image ObjectwitchImage20;
    public Image ObjectwitchImage30;
    public Image ObjectwitchImage40;
    public Image ObjectwitchImage50;

    public Image ObjectwitchImage01;
    public Image ObjectwitchImage11;
    public Image ObjectwitchImage21;
    public Image ObjectwitchImage31;
    public Image ObjectwitchImage41;
    public Image ObjectwitchImage51;
    
    public Image ObjectwitchImage02;
    public Image ObjectwitchImage12;
    public Image ObjectwitchImage22;
    public Image ObjectwitchImage32;
    public Image ObjectwitchImage42;
    public Image ObjectwitchImage52;

    public Image ObjectwitchImage03;
    public Image ObjectwitchImage13;
    public Image ObjectwitchImage23;
    public Image ObjectwitchImage33;
    public Image ObjectwitchImage43;
    public Image ObjectwitchImage53;

    public Image ObjectwitchImage04;
    public Image ObjectwitchImage14;
    public Image ObjectwitchImage24;
    public Image ObjectwitchImage34;
    public Image ObjectwitchImage44;
    public Image ObjectwitchImage54;

    public Image ObjectwitchImage05;
    public Image ObjectwitchImage15;
    public Image ObjectwitchImage25;
    public Image ObjectwitchImage35;
    public Image ObjectwitchImage45;
    public Image ObjectwitchImage55;

    public Image ObjectwitchImage06;
    public Image ObjectwitchImage16;
    public Image ObjectwitchImage26;
    public Image ObjectwitchImage36;
    public Image ObjectwitchImage46;
    public Image ObjectwitchImage56;

    public Image ObjectwitchImageTurn;
    public Image ObjectwitchImageTurn1;

    public Sprite image50;
    public Sprite image40;

    public Sprite colorRed;
    public Sprite colorBlue;
    public Sprite colorWhite;


    public GameObject menuPanel;
    public GameObject gameOverPanel;
    public Text gameOverText;
    
    int[,] x = new int[6, 7];
    Random rand = new Random();
   
    int s1 = 5;
    int s2 = 5;
    int s3 = 5;
    int s4 = 5;
    int s5 = 5;
    int s6 = 5;
    int s7 = 5;
    int player;
    int color;

    bool res1;
    bool res2;
    bool res3;
    bool res4;
    bool res5;
    bool res6;
    bool res7;
    bool res8;
    bool res9;
    bool res10;
    bool res11;
    bool res12;

    int times = 0;
    
    public Button btnn1;
    public Button btnn2;
    public Button btnn3;
    public Button btnn4;
    public Button btnn5;
    public Button btnn6;
    public Button btnn7;

    public Button start1;
    public Button start2;

    void Awake()
    {
        gameOverPanel.SetActive(false);
        enableButtons();
        start1.interactable = true;
        start2.interactable = true;
        ObjectwitchImageTurn.sprite = colorRed;
        ObjectwitchImageTurn1.sprite = colorBlue;
    }
    
    private void get_winner()
    {
        //Console.WriteLine("last player " + player);
        if (player == 2)
        {
            // Console.WriteLine("last player 1");
            if (compare_h1() == true || compare_h2() == true || compare_h3() == true || compare_h4() == true || compare_v1() == true || compare_v2() == true || compare_v3() == true || compare_D1() == true || compare_D2() == true || compare_D3() == true || compare_D4() == true || compare_D5() == true || compare_D6() == true)
            {
                gameOverPanel.SetActive(true);
                gameOverText.text = "Player 1 won!!";
            }
        }
        else if (player == 1)
        {
            if (compare_h1() == true || compare_h2() == true || compare_h3() == true || compare_h4() == true || compare_v1() == true || compare_v2() == true || compare_v3() == true || compare_D1() == true || compare_D2() == true || compare_D3() == true || compare_D4() == true || compare_D5() == true || compare_D6() == true)
            {
                gameOverPanel.SetActive(true);
                gameOverText.text = "Player 2 won!!";
                /* Console.WriteLine("player 2 won");
                 MessageBox.Show("Player 2 won");
                 Menu m = new Menu();
                 m.Show();*/
                //  this.Hide();
            }
            // Console.WriteLine("last player 2");

        }
        if (times > 41)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "It's a draw!!";

        }

    }
    private int delta()
    {
        if (player == 1)
        {
            ObjectwitchImageTurn.sprite = colorWhite;
            ObjectwitchImageTurn1.sprite = colorBlue;

            times += 1;
            player = 2;//change player
            color = 1;//print color red where ever the boton is press 
            }
        else if (player == 2)
        {
            times += 1;
            ObjectwitchImageTurn.sprite = colorRed;
            ObjectwitchImageTurn1.sprite = colorWhite;

            player = 1;//change player
            color = 2;//print color blue where ever the boton is press 
        }
        return color;
    }


    public void btn1()
    {
        // GetComponent<Image>().sprite = image50;
        // ObjectwitchImage.sprite = image50;//good one
        int aux = delta();
        if (aux == 1)//gamer 1
        {
           // Console.WriteLine("Color Red out");
            if (s1 == 5)
            {
                ObjectwitchImage50.sprite = colorRed;
              //  lbl_section_150.Image = Properties.Resources.rsz_p2_red;
                x[5, 0] = 1;
            }
            if (s1 == 4)
            {
                ObjectwitchImage40.sprite = colorRed;
                // lbl_section_140.Image = Properties.Resources.rsz_p2_red;
                x[4, 0] = 1;
            }
            if (s1 == 3)
            {
                ObjectwitchImage30.sprite = colorRed;
                //lbl_section_130.Image = Properties.Resources.rsz_p2_red;
                x[3, 0] = 1;
            }
            if (s1 == 2)
            {
                ObjectwitchImage20.sprite = colorRed;
                //lbl_section_120.Image = Properties.Resources.rsz_p2_red;
                x[2, 0] = 1;
            }
            if (s1 == 1)
            {
                ObjectwitchImage10.sprite = colorRed;
                //   lbl_section_110.Image = Properties.Resources.rsz_p2_red;
                x[1, 0] = 1;
            }
            if (s1 == 0)
            {
                ObjectwitchImage00.sprite = colorRed;
                //  lbl_section_100.Image = Properties.Resources.rsz_p2_red;
                x[0, 0] = 1;
            }
        }
        else if (aux == 2)//game 2
        {
            if (s1 == 5)
            {
                ObjectwitchImage50.sprite = colorRed;
                //  lbl_section_150.Image = Properties.Resources.rsz_p1_blue;
                x[5, 0] = 2;
            }
            if (s1 == 4)
            {
                ObjectwitchImage40.sprite = colorBlue;
                //  lbl_section_140.Image = Properties.Resources.rsz_p1_blue;
                x[4, 0] = 2;
            }
            if (s1 == 3)
            {
                ObjectwitchImage30.sprite = colorBlue;
                //  lbl_section_130.Image = Properties.Resources.rsz_p1_blue;
                x[3, 0] = 2;
            }
            if (s1 == 2)
            {
                ObjectwitchImage20.sprite = colorBlue;
                //  lbl_section_120.Image = Properties.Resources.rsz_p1_blue;
                x[2, 0] = 2;
            }
            if (s1 == 1)
            {
                ObjectwitchImage10.sprite = colorBlue;
                //   lbl_section_110.Image = Properties.Resources.rsz_p1_blue;
                x[1, 0] = 2;
            }
            if (s1 == 0)
            {
                ObjectwitchImage00.sprite = colorBlue;
                //  lbl_section_100.Image = Properties.Resources.rsz_p1_blue;
                x[0, 0] = 2;
            }
         //   Console.WriteLine("Color Blue out");
        }

        s1 -= 1;
        //print();
        compare_h1();
        compare_h2();
        compare_h3();
        compare_h4();
        compare_v1();
        compare_v2();
        compare_v3();
        compare_D1();
        compare_D2();
        compare_D3();
        compare_D4();
        compare_D5();
        compare_D6();
        get_winner();
        enableButtons();

    }
    public void btn2()
    {
        int aux = delta();
        if (aux == 1)
        {
          //  Console.WriteLine("Color Red out");
            if (s2 == 5)
            {
                ObjectwitchImage51.sprite = colorRed;
                //    lbl_section_251.Image = Properties.Resources.rsz_p2_red;
                x[5, 1] = 1;
            }
            if (s2 == 4)
            {
                ObjectwitchImage41.sprite = colorRed;
                //  lbl_section_241.Image = Properties.Resources.rsz_p2_red;
                x[4, 1] = 1;
            }
            if (s2 == 3)
            {
                ObjectwitchImage31.sprite = colorRed;
                //lbl_section_231.Image = Properties.Resources.rsz_p2_red;
                x[3, 1] = 1;
            }
            if (s2 == 2)
            {
                ObjectwitchImage21.sprite = colorRed;
                //lbl_section_221.Image = Properties.Resources.rsz_p2_red;
                x[2, 1] = 1;
            }
            if (s2 == 1)
            {
                ObjectwitchImage11.sprite = colorRed;
                //lbl_section_211.Image = Properties.Resources.rsz_p2_red;
                x[1, 1] = 1;
            }
            if (s2 == 0)
            {
                ObjectwitchImage01.sprite = colorRed;
                //lbl_section_201.Image = Properties.Resources.rsz_p2_red;
                x[0, 1] = 1;
            }
        }
        else if (aux == 2)
        {
            //Console.WriteLine("Color Blue out");
            if (s2 == 5)
            {
                ObjectwitchImage51.sprite = colorBlue;
                //  lbl_section_251.Image = Properties.Resources.rsz_p1_blue;
                x[5, 1] = 2;
            }
            if (s2 == 4)
            {
                ObjectwitchImage41.sprite = colorBlue;
                //lbl_section_241.Image = Properties.Resources.rsz_p1_blue;
                x[4, 1] = 2;
            }
            if (s2 == 3)
            {
                ObjectwitchImage31.sprite = colorBlue;
                //lbl_section_231.Image = Properties.Resources.rsz_p1_blue;
                x[3, 1] = 2;
            }
            if (s2 == 2)
            {
                ObjectwitchImage21.sprite = colorBlue;
                //lbl_section_221.Image = Properties.Resources.rsz_p1_blue;
                x[2, 1] = 2;
            }
            if (s2 == 1)
            {
                ObjectwitchImage11.sprite = colorBlue;
                //lbl_section_211.Image = Properties.Resources.rsz_p1_blue;
                x[1, 1] = 2;
            }
            if (s2 == 0)
            {
                ObjectwitchImage01.sprite = colorBlue;
                //lbl_section_201.Image = Properties.Resources.rsz_p1_blue;
                x[0, 1] = 2;
            }
        }

        s2 -= 1;
        //print();
        compare_h1();
        compare_h2();
        compare_h3();
        compare_h4();
        compare_v1();
        compare_v2();
        compare_v3();
        compare_D1();
        compare_D2();
        compare_D3();
        compare_D4();
        compare_D5();
        compare_D6();
        get_winner();
        enableButtons();
    }
    public void btn3()
    {
        int aux = delta();
        if (aux == 1)
        {
            if (s3 == 5)
            {
                ObjectwitchImage52.sprite = colorRed;
                //lbl_section_352.Image = Properties.Resources.rsz_p2_red;
                x[5, 2] = 1;
            }
            if (s3 == 4)
            {
                ObjectwitchImage42.sprite = colorRed;
                //lbl_section_342.Image = Properties.Resources.rsz_p2_red;
                x[4, 2] = 1;
            }
            if (s3 == 3)
            {
                ObjectwitchImage32.sprite = colorRed;
                //lbl_section_332.Image = Properties.Resources.rsz_p2_red;
                x[3, 2] = 1;
            }
            if (s3 == 2)
            {
                ObjectwitchImage22.sprite = colorRed;
                //lbl_section_322.Image = Properties.Resources.rsz_p2_red;
                x[2, 2] = 1;
            }
            if (s3 == 1)
            {
                ObjectwitchImage12.sprite = colorRed;
                //lbl_section_312.Image = Properties.Resources.rsz_p2_red;
                x[1, 2] = 1;
            }
            if (s3 == 0)
            {
                ObjectwitchImage02.sprite = colorRed;
                //lbl_section_302.Image = Properties.Resources.rsz_p2_red;
                x[0, 2] = 1;
            }
        }
        else if (aux == 2)
        {
            if (s3 == 5)
            {
                ObjectwitchImage52.sprite = colorBlue;
                //lbl_section_352.Image = Properties.Resources.rsz_p1_blue;
                x[5, 2] = 2;
            }
            if (s3 == 4)
            {
                ObjectwitchImage42.sprite = colorBlue;
                //lbl_section_342.Image = Properties.Resources.rsz_p1_blue;
                x[4, 2] = 2;
            }
            if (s3 == 3)
            {
                ObjectwitchImage32.sprite = colorBlue;
                //lbl_section_332.Image = Properties.Resources.rsz_p1_blue;
                x[3, 2] = 2;
            }
            if (s3 == 2)
            {
                ObjectwitchImage22.sprite = colorBlue;
                //lbl_section_322.Image = Properties.Resources.rsz_p1_blue;
                x[2, 2] = 2;
            }
            if (s3 == 1)
            {
                ObjectwitchImage12.sprite = colorBlue;
                //lbl_section_312.Image = Properties.Resources.rsz_p1_blue;
                x[1, 2] = 2;
            }
            if (s3 == 0)
            {
                ObjectwitchImage02.sprite = colorBlue;
                //lbl_section_302.Image = Properties.Resources.rsz_p1_blue;
                x[0, 2] = 2;
            }
        }

        s3 -= 1;
       // print();
        compare_h1();
        compare_h2();
        compare_h3();
        compare_h4();
        compare_v1();
        compare_v2();
        compare_v3();
        compare_D1();
        compare_D2();
        compare_D3();
        compare_D4();
        compare_D5();
        compare_D6();
        get_winner();
        enableButtons();
    }
    public void btn4()
    {
        int aux = delta();
        if (aux == 1)
        {
            if (s4 == 5)
            {
                ObjectwitchImage53.sprite = colorRed;
                //lbl_section_453.Image = Properties.Resources.rsz_p2_red;
                x[5, 3] = 1;
            }
            if (s4 == 4)
            {
                ObjectwitchImage43.sprite = colorRed;
                //    lbl_section_443.Image = Properties.Resources.rsz_p2_red;
                x[4, 3] = 1;
            }
            if (s4 == 3)
            {
                ObjectwitchImage33.sprite = colorRed;
                //  lbl_section_433.Image = Properties.Resources.rsz_p2_red;
                x[3, 3] = 1;
            }
            if (s4 == 2)
            {
                ObjectwitchImage23.sprite = colorRed;
                //lbl_section_423.Image = Properties.Resources.rsz_p2_red;
                x[2, 3] = 1;
            }
            if (s4 == 1)
            {
                ObjectwitchImage13.sprite = colorRed;
                //  lbl_section_413.Image = Properties.Resources.rsz_p2_red;
                x[1, 3] = 1;
            }
            if (s4 == 0)
            {
                ObjectwitchImage03.sprite = colorRed;
                //lbl_section_403.Image = Properties.Resources.rsz_p2_red;
                x[0, 3] = 1;
            }

        }
        else if (aux == 2)
        {
            if (s4 == 5)
            {
                ObjectwitchImage53.sprite = colorBlue;
                //lbl_section_453.Image = Properties.Resources.rsz_p1_blue;
                x[5, 3] = 2;
            }
            if (s4 == 4)
            {
                ObjectwitchImage43.sprite = colorBlue;
                //lbl_section_443.Image = Properties.Resources.rsz_p1_blue;
                x[4, 3] = 2;
            }
            if (s4 == 3)
            {
                ObjectwitchImage33.sprite = colorBlue;
                // lbl_section_433.Image = Properties.Resources.rsz_p1_blue;
                x[3, 3] = 2;
            }
            if (s4 == 2)
            {
                ObjectwitchImage23.sprite = colorBlue;
                //lbl_section_423.Image = Properties.Resources.rsz_p1_blue;
                x[2, 3] = 2;
            }
            if (s4 == 1)
            {
                ObjectwitchImage13.sprite = colorBlue;
                //lbl_section_413.Image = Properties.Resources.rsz_p1_blue;
                x[1, 3] = 2;
            }
            if (s4 == 0)
            {
                ObjectwitchImage03.sprite = colorBlue;
                // lbl_section_403.Image = Properties.Resources.rsz_p1_blue;
                x[0, 3] = 2;
            }
        }

        s4 -= 1;
      //  print();
        compare_h1();
        compare_h2();
        compare_h3();
        compare_h4();
        compare_v1();
        compare_v2();
        compare_v3();
        compare_D1();
        compare_D2();
        compare_D3();
        compare_D4();
        compare_D5();
        compare_D6();
        get_winner();
        enableButtons();

    }
    public void btn5()
    {
        int aux = delta();
        if (aux == 1)
        {
            if (s5 == 5)
            {
                ObjectwitchImage54.sprite = colorRed;
                //    lbl_section_554.Image = Properties.Resources.rsz_p2_red;
                x[5, 4] = 1;
            }
            if (s5 == 4)
            {
                ObjectwitchImage44.sprite = colorRed;
                //  lbl_section_544.Image = Properties.Resources.rsz_p2_red;
                x[4, 4] = 1;
            }
            if (s5 == 3)
            {
                ObjectwitchImage34.sprite = colorRed;
                //  lbl_section_534.Image = Properties.Resources.rsz_p2_red;
                x[3, 4] = 1;
            }
            if (s5 == 2)
            {
                ObjectwitchImage24.sprite = colorRed;
                //    lbl_section_524.Image = Properties.Resources.rsz_p2_red;
                x[2, 4] = 1;
            }
            if (s5 == 1)
            {
                ObjectwitchImage14.sprite = colorRed;
                //   lbl_section_514.Image = Properties.Resources.rsz_p2_red;
                x[1, 4] = 1;
            }
            if (s5 == 0)
            {
                ObjectwitchImage04.sprite = colorRed;
                //  lbl_section_504.Image = Properties.Resources.rsz_p2_red;
                x[0, 4] = 1;
            }
        }
        else if (aux == 2)
        {
            if (s5 == 5)
            {
                ObjectwitchImage54.sprite = colorBlue;
                //    lbl_section_554.Image = Properties.Resources.rsz_p1_blue;
                x[5, 4] = 2;
            }
            if (s5 == 4)
            {
                ObjectwitchImage44.sprite = colorBlue;
                //    lbl_section_544.Image = Properties.Resources.rsz_p1_blue;
                x[4, 4] = 2;
            }
            if (s5 == 3)
            {
                ObjectwitchImage34.sprite = colorBlue;
                //   lbl_section_534.Image = Properties.Resources.rsz_p1_blue;
                x[3, 4] = 2;
            }
            if (s5 == 2)
            {
                ObjectwitchImage24.sprite = colorBlue;
                //   lbl_section_524.Image = Properties.Resources.rsz_p1_blue;
                x[2, 4] = 2;
            }
            if (s5 == 1)
            {
                ObjectwitchImage14.sprite = colorBlue;
                //   lbl_section_514.Image = Properties.Resources.rsz_p1_blue;
                x[1, 4] = 2;
            }
            if (s5 == 0)
            {
                ObjectwitchImage04.sprite = colorBlue;
                //    lbl_section_504.Image = Properties.Resources.rsz_p1_blue;
                x[0, 4] = 2;
            }
        }

        s5 -= 1;
        //print();
        compare_h1();
        compare_h2();
        compare_h3();
        compare_h4();
        compare_v1();
        compare_v2();
        compare_v3();
        compare_D1();
        compare_D2();
        compare_D3();
        compare_D4();
        compare_D5();
        compare_D6();
        get_winner();
        enableButtons();
    }
    public void btn6()
    {
        int aux = delta();
        if (aux == 1)
        {
            if (s6 == 5)
            {
                ObjectwitchImage55.sprite = colorRed;
                //      lbl_section_655.Image = Properties.Resources.rsz_p2_red;
                x[5, 5] = 1;
            }
            if (s6 == 4)
            {
                ObjectwitchImage45.sprite = colorRed;
                //        lbl_section_645.Image = Properties.Resources.rsz_p2_red;
                x[4, 5] = 1;
            }
            if (s6 == 3)
            {
                ObjectwitchImage35.sprite = colorRed;
                //    lbl_section_635.Image = Properties.Resources.rsz_p2_red;
                x[3, 5] = 1;
            }
            if (s6 == 2)
            {
                ObjectwitchImage25.sprite = colorRed;
                //       lbl_section_625.Image = Properties.Resources.rsz_p2_red;
                x[2, 5] = 1;
            }
            if (s6 == 1)
            {
                ObjectwitchImage15.sprite = colorRed;
                //   lbl_section_615.Image = Properties.Resources.rsz_p2_red;
                x[1, 5] = 1;
            }
            if (s6 == 0)
            {
                ObjectwitchImage05.sprite = colorRed;
                //      lbl_section_605.Image = Properties.Resources.rsz_p2_red;
                x[0, 5] = 1;
            }
        }
        else if (aux == 2)
        {
            if (s6 == 5)
            {
                ObjectwitchImage55.sprite = colorBlue;
                //   lbl_section_655.Image = Properties.Resources.rsz_p1_blue;
                x[5, 5] = 2;
            }
            if (s6 == 4)
            {
                ObjectwitchImage45.sprite = colorBlue;
                //    lbl_section_645.Image = Properties.Resources.rsz_p1_blue;
                x[4, 5] = 2;
            }
            if (s6 == 3)
            {
                ObjectwitchImage35.sprite = colorBlue;
                //   lbl_section_635.Image = Properties.Resources.rsz_p1_blue;
                x[3, 5] = 2;
            }
            if (s6 == 2)
            {
                ObjectwitchImage25.sprite = colorBlue;
                //   lbl_section_625.Image = Properties.Resources.rsz_p1_blue;
                x[2, 5] = 2;
            }
            if (s6 == 1)
            {
                ObjectwitchImage15.sprite = colorBlue;
                //  lbl_section_615.Image = Properties.Resources.rsz_p1_blue;
                x[1, 5] = 2;
            }
            if (s6 == 0)
            {
                ObjectwitchImage05.sprite = colorBlue;
                //    lbl_section_605.Image = Properties.Resources.rsz_p1_blue;
                x[0, 5] = 2;
            }
        }

        s6 -= 1;
        //print();
        compare_h1();
        compare_h2();
        compare_h3();
        compare_h4();
        compare_v1();
        compare_v2();
        compare_v3();
        compare_D1();
        compare_D2();
        compare_D3();
        compare_D4();
        compare_D5();
        compare_D6();
        get_winner();
        enableButtons();
    }
    public void btn7()
    {
        int aux = delta();
        if (aux == 1)
        {
            if (s7 == 5)
            {
                ObjectwitchImage56.sprite = colorRed;
                //     lbl_section_756.Image = Properties.Resources.rsz_p2_red;
                x[5, 6] = 1;
            }
            if (s7 == 4)
            {
                ObjectwitchImage46.sprite = colorRed;
                //     lbl_section_746.Image = Properties.Resources.rsz_p2_red;
                x[4, 6] = 1;
            }
            if (s7 == 3)
            {
                ObjectwitchImage36.sprite = colorRed;
                //    lbl_section_736.Image = Properties.Resources.rsz_p2_red;
                x[3, 6] = 1;
            }
            if (s7 == 2)
            {
                ObjectwitchImage26.sprite = colorRed;
                //    lbl_section_726.Image = Properties.Resources.rsz_p2_red;
                x[2, 6] = 1;
            }
            if (s7 == 1)
            {
                ObjectwitchImage16.sprite = colorRed;
                //    lbl_section_716.Image = Properties.Resources.rsz_p2_red;
                x[1, 6] = 1;
            }
            if (s7 == 0)
            {
                ObjectwitchImage06.sprite = colorRed;
                //    lbl_section_706.Image = Properties.Resources.rsz_p2_red;
                x[0, 6] = 1;
            }
        }
        else if (aux == 2)
        {
            if (s7 == 5)
            {
                ObjectwitchImage56.sprite = colorBlue;
                //   lbl_section_756.Image = Properties.Resources.rsz_p1_blue;
                x[5, 6] = 2;
            }
            if (s7 == 4)
            {
                ObjectwitchImage46.sprite = colorBlue;
                //   lbl_section_746.Image = Properties.Resources.rsz_p1_blue;
                x[4, 6] = 2;
            }
            if (s7 == 3)
            {
                ObjectwitchImage36.sprite = colorBlue;
                //   lbl_section_736.Image = Properties.Resources.rsz_p1_blue;
                x[3, 6] = 2;
            }
            if (s7 == 2)
            {
                ObjectwitchImage26.sprite = colorBlue;
                //   lbl_section_726.Image = Properties.Resources.rsz_p1_blue;
                x[2, 6] = 2;
            }
            if (s7 == 1)
            {
                ObjectwitchImage16.sprite = colorBlue;
                //    lbl_section_716.Image = Properties.Resources.rsz_p1_blue;
                x[1, 6] = 2;
            }
            if (s7 == 0)
            {
                ObjectwitchImage06.sprite = colorBlue;
                //    lbl_section_706.Image = Properties.Resources.rsz_p1_blue;
                x[0, 6] = 2;
            }
        }
        s7 -= 1;
      //  print();
        compare_h1();
        compare_h2();
        compare_h3();
        compare_h4();
        compare_v1();
        compare_v2();
        compare_v3();
        compare_D1();
        compare_D2();
        compare_D3();
        compare_D4();
        compare_D5();
        compare_D6();
        get_winner();
        enableButtons();
    }
    /**************************************************************************************/
    public void setStartingSide(string start)
    {
        if (start=="1")
        {
            player = 1;
            ObjectwitchImageTurn1.sprite = colorWhite;
        }
        else
        {
            ObjectwitchImageTurn.sprite = colorWhite;
            player = 2;
        }
        startGame();
    }
    void startGame()
    {
        menuPanel.SetActive(false);
        btnn1.interactable = true;
        btnn2.interactable = true;
        btnn3.interactable = true;
        btnn4.interactable = true;
        btnn5.interactable = true;
        btnn6.interactable = true;
        btnn7.interactable = true;
        start1.interactable = false;
        start2.interactable = false;
        
    }
    public void enableButtons()
    {
        if (s1 < 0)
        {
            btnn1.interactable = false;
        }
        if (s2 < 0)
        {
            btnn2.interactable = false;
        }
        if (s3 < 0)
        {
            btnn3.interactable = false;
        }
        if (s4 < 0)
        {
            btnn4.interactable = false;
        }
        if (s5 < 0)
        {
            btnn5.interactable = false;
        }
        if (s6 < 0)
        {
            btnn6.interactable = false;
        }
        if (s7 < 0)
        {
            btnn7.interactable = false;
        }
    }
    /***************************************************************************************/
    private bool compare_h1()
    {

        for (int i = 0; i <= 5; i++)
        {
            if ((x[i, 0] == 0) && (x[i, 1] == 0) && (x[i, 2] == 0) && (x[i, 3] == 0))
            {
                //Console.WriteLine("nopH1");
            }
            else if ((x[i, 0] == x[i, 1]) && (x[i, 2] == x[i, 3]) && (x[i, 0] == x[i, 2]) && (x[i, 1] == x[i, 3]))
            {
                res1 = true;
              //  Console.WriteLine("yesH1");
            }
            else
            {
                //Console.WriteLine("nopH1");
            }
        }
        return res1;
    }
    private bool compare_h2()
    {
        for (int i = 0; i <= 5; i++)
        {
            if ((x[i, 1] == 0) && (x[i, 2] == 0) && (x[i, 3] == 0) && (x[i, 4] == 0))
            {
                //    Console.WriteLine("nopV4");
            }
            else if ((x[i, 1] == x[i, 2]) && (x[i, 3] == x[i, 4]) && (x[i, 1] == x[i, 3]) && (x[i, 2] == x[i, 4]))
            {
                res2 = true;
              //  Console.WriteLine("yesh2");
            }
            else
            {
                //Console.WriteLine("nopV4");
            }
        }
        return res2;
    }
    private bool compare_h3()
    {
        for (int i = 0; i <= 5; i++)
        {
            if ((x[i, 2] == 0) && (x[i, 3] == 0) && (x[i, 4] == 0) && (x[i, 5] == 0))
            {
                //    Console.WriteLine("nopV4");
            }
            else if ((x[i, 2] == x[i, 3]) && (x[i, 4] == x[i, 5]) && (x[i, 2] == x[i, 4]) && (x[i, 3] == x[i, 5]))
            {
                res3 = true;
              //  Console.WriteLine("yesh3");
            }
            else
            {
                //Console.WriteLine("nopV4");
            }
        }
        return res3;
    }
    private bool compare_h4()
    {
        for (int i = 0; i <= 5; i++)
        {
            if ((x[i, 3] == 0) && (x[i, 4] == 0) && (x[i, 5] == 0) && (x[i, 6] == 0))
            {
                //    Console.WriteLine("nopV4");
            }
            else if ((x[i, 3] == x[i, 4]) && (x[i, 5] == x[i, 6]) && (x[i, 3] == x[i, 5]) && (x[i, 4] == x[i, 6]))
            {
                res4 = true;
              //  Console.WriteLine("yesh4");
            }
            else
            {
                //Console.WriteLine("nopV4");
            }
        }
        return res4;
    }
    /**************************************************************************************/
    private bool compare_v1()
    {
        for (int i = 0; i <= 6; i++)
        {
            if ((x[0, i] == 0) && (x[1, i] == 0) && (x[2, i] == 0) && (x[3, i] == 0))
            {
                //     Console.WriteLine("nopH2");
            }
            else if ((x[0, i] == x[1, i]) && (x[2, i] == x[3, i]) && (x[0, i] == x[2, i]) && (x[1, i] == x[3, i]))
            {
                res5 = true;
         //       Console.WriteLine("yesV1");
            }
            else
            {
                // Console.WriteLine("nopH2");
            }
        }
        return res5;
    }
    private bool compare_v2()
    {
        for (int i = 0; i <= 6; i++)
        {
            if ((x[1, i] == 0) && (x[2, i] == 0) && (x[3, i] == 0) && (x[4, i] == 0))
            {
                //     Console.WriteLine("nopH2");
            }
            else if ((x[1, i] == x[2, i]) && (x[3, i] == x[4, i]) && (x[1, i] == x[3, i]) && (x[2, i] == x[4, i]))
            {
                res6 = true;
        //        Console.WriteLine("yesV2");
            }
            else
            {
                // Console.WriteLine("nopH2");
            }
        }

        return res6;
    }
    private bool compare_v3()
    {
        for (int i = 0; i <= 6; i++)
        {
            if ((x[2, i] == 0) && (x[3, i] == 0) && (x[4, i] == 0) && (x[5, i] == 0))
            {
                //     Console.WriteLine("nopH2");
            }
            else if ((x[2, i] == x[3, i]) && (x[4, i] == x[5, i]) && (x[2, i] == x[4, i]) && (x[3, i] == x[5, i]))
            {
                res7 = true;
          //      Console.WriteLine("yesV3");
            }
            else
            {
                // Console.WriteLine("nopH2");
            }
        }
        return res7;
    }
    /*****************************************************************************************/
    private bool compare_D1()
    {
        /*
            if (((x[0, 0] == x[1, 1]) && (x[2, 2] == x[3, 3])) && ((x[1, 1] == x[2, 2]) && (x[3, 3] == x[3, 3]))&& ((x[0, 0] !=0 && x[1, 1] != 0) && (x[2, 2] !=0 && x[3, 3] != 0)))
            {
                Console.WriteLine("yesD1.");
            }
            else if (((x[0, 1] == x[1, 2]) && (x[2, 3] == x[3, 4])) && ((x[1, 2] == x[2, 3]) && (x[0, 1] == x[3, 4])) && ((x[0, 1] != 0 && x[1, 2] != 0) && (x[2, 3] != 0 && x[3, 4] != 0)))
            {
                Console.WriteLine("yesD1..");
            }
            else if (((x[0, 2] == x[1, 3]) && (x[2, 4] == x[3, 5])) && ((x[1, 3] == x[2, 4]) && (x[0, 2] == x[3, 5])) && ((x[0, 2] != 0 && x[1, 3] != 0) && (x[2, 4] != 0 && x[3, 5] != 0)))
            {
                Console.WriteLine("yesD1...");
            }
            else if (((x[0, 3] == x[1, 4]) && (x[2, 5] == x[3, 6])) && ((x[1, 4] == x[2, 5]) && (x[0, 3] == x[3, 6])) && ((x[0, 3] != 0 && x[1, 4] != 0) && (x[2, 5] != 0 && x[3, 6] != 0)))
            {
                Console.WriteLine("yesD1....");
            }
        */


        int i = 0, j = 1, k = 2, z = 3;

        for (int iter = 0; iter <= 5; iter++)
        {
            if ((i != 4 && j != 5 && k != 6 && z != 7))
            {
                //  Console.WriteLine(" i" + i + " j" + j + " k" + k + " z" + z);
                if ((x[0, i] == 0 && x[1, j] == 0) && (x[2, k] == 0 && x[3, z] == 0))
                {

                }
                else
                {
                    if (((x[0, i] == x[1, j]) && (x[2, k] == x[3, z])) && ((x[1, j] == x[2, k]) && (x[0, i] == x[3, z])))
                    {
        //                Console.WriteLine("yesD1");

                        res7 = true;
                    }
                    i += 1; j += 1; k += 1; z += 1;
                }

            }


        }
        /*for (int i = 0; i <= 3; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                for (int k = 2; k <= 5; k++)
                {
                    for (int it = 3; it <= 6; it++)
                    {
                        if ((x[0, i] == 0 && x[1, j] == 0) && (x[2, k] == 0 && x[3, it] == 0))
                        {

                        }
                        else if (((x[0, i] == x[1, j]) && (x[2, k] == x[3, it])) && ((x[0, i] == x[2, k]) && (x[1, j] == x[3, it])))
                        {
                            Console.WriteLine("" + i, j, k, it);
                            Console.WriteLine("yesD1");
                            res6 = true;

                        }
                    }
                }


            }
        }*/
        /* for (int j = 2; j <= 5; j++)
         {
             for (int i = 0; i <= 3; i++)
             {

                 if ((x[0, i] == 0 && x[1, i+1] == 0) && (x[2, j] == 0 && x[3, j+1] == 0))
                 {

                 }else if (((x[0,i]==x[1,i+1])&&(x[2,j]==x[3,j+1])) && ((x[0,i]==x[2,j])&&(x[1,i+1]==x[3,j+1])))
                 {
                         Console.WriteLine("yesD1");
                         res6 = true;

                 }

             }
         }
         *//*
        int i = 0, j = 1, k = 2, z = 3;

        for (int iter = 0; iter <= 4; iter++)
        {
            if ((i != 3 && j != 4 && k != 5 && z != 6))
            {
                if ((x[0, i] == 0 && x[1, j] == 0) && (x[2, k] == 0 && x[3, z] == 0))
                {

                }
                else
                {
                    if (((x[0, i] == x[1, j]) && (x[2, k] == x[3, z])) && ((x[1, j] == x[2, k]) && (x[0, i] == x[3, z])))
                    {
                        Console.WriteLine("yesD1");
                        res6 = true;
                    }

                }
                i++; j++; k++; z++;
            }

        }
        */

        return res7;
    }
    private bool compare_D2()
    {
        /*
        if (((x[1, 0] == x[2, 1]) && (x[3, 2] == x[4, 3])) && ((x[2, 1] == x[3, 2]) && (x[1, 0] == x[4, 3])) && ((x[1, 0] != 0 && x[2, 1] != 0) && (x[3, 2] != 0 && x[4, 3] != 0)))
        {
            Console.WriteLine("yesD2.");
        }
        else if (((x[1, 1] == x[2, 2]) && (x[3, 3] == x[4, 4])) && ((x[2, 2] == x[3, 3]) && (x[1, 1] == x[4, 4])) && ((x[1, 1] != 0 && x[2, 2] != 0) && (x[3, 3] != 0 && x[4, 4] != 0)))
        {
            Console.WriteLine("yesD2..");
        }
        else if (((x[1, 2] == x[2, 3]) && (x[3, 4] == x[4, 5])) && ((x[2, 3] == x[3, 4]) && (x[1, 2] == x[4, 5])) && ((x[1, 2] != 0 && x[2, 3] != 0) && (x[3, 4] != 0 && x[4, 5] != 0)))
        {
            Console.WriteLine("yesD2...");
        }
        else if (((x[1, 3] == x[2, 4]) && (x[3, 5] == x[4, 6])) && ((x[2, 4] == x[3, 5]) && (x[1, 3] == x[4, 6])) && ((x[1, 3] != 0 && x[2, 4] != 0) && (x[3, 5] != 0 && x[4, 6] != 0)))
        {
            Console.WriteLine("yesD2....");
        }*/

        int i = 0, j = 1, k = 2, z = 3;

        for (int iter = 0; iter <= 5; iter++)
        {
            if ((i != 4 && j != 5 && k != 6 && z != 7))
            {
                if ((x[1, i] == 0 && x[2, j] == 0) && (x[3, k] == 0 && x[4, z] == 0))
                {

                }
                else
                {
                    if (((x[1, i] == x[2, j]) && (x[3, k] == x[4, z])) && ((x[2, j] == x[3, k]) && (x[1, i] == x[4, z])))
                    {
       //                 Console.WriteLine("yesD2");

                        res8 = true;
                    }
                    i += 1; j += 1; k += 1; z += 1;
                }

            }


        }
        /*for (int i = 0; i <= 3; i++)
        {
            for (int j = 2; j <= 5; j++)
            {
                if ((x[1, i] == 0 && x[2, i + 1] == 0) && (x[3, j] == 0 && x[4, j + 1] == 0))
                {

                }
                else
                {
                    if (((x[1, i] == x[2, i + 1]) && (x[3, j] == x[4, j + 1])) && ((x[1, i] == x[4, j + 1]) && (x[2, i + 1] == x[3, j])))
                    {
                        Console.WriteLine("yesD2");
                        res6 = true;

                    }
                }
            }
        }*/
        return res8;
    }
    private bool compare_D3()
    {/*
            if (((x[1, 0] == x[2, 1]) && (x[3, 2] == x[4, 3])) && ((x[2, 1] == x[3, 2]) && (x[1, 0] == x[4, 3])) && ((x[1, 0] != 0 && x[2, 1] != 0) && (x[3, 2] != 0 && x[4, 3] != 0)))
            {
                Console.WriteLine("yesD2.");
            }
            else if (((x[1, 1] == x[2, 2]) && (x[3, 3] == x[4, 4])) && ((x[2, 2] == x[3, 3]) && (x[1, 1] == x[4, 4])) && ((x[1, 1] != 0 && x[2, 2] != 0) && (x[3, 3] != 0 && x[4, 4] != 0)))
            {
                Console.WriteLine("yesD2..");
            }
            else if (((x[1, 2] == x[2, 3]) && (x[3, 4] == x[4, 5])) && ((x[2, 3] == x[3, 4]) && (x[1, 2] == x[4, 5])) && ((x[1, 2] != 0 && x[2, 3] != 0) && (x[3, 4] != 0 && x[4, 5] != 0)))
            {
                Console.WriteLine("yesD2...");
            }
            else if (((x[1, 3] == x[2, 4]) && (x[3, 5] == x[4, 6])) && ((x[2, 4] == x[3, 5]) && (x[1, 3] == x[4, 6])) && ((x[1, 3] != 0 && x[2, 4] != 0) && (x[3, 5] != 0 && x[4, 6] != 0)))
            {
                Console.WriteLine("yesD2....");
            }*/

        int i = 0, j = 1, k = 2, z = 3;

        for (int iter = 0; iter <= 5; iter++)
        {
            if ((i != 4 && j != 5 && k != 6 && z != 7))
            {
                //Console.WriteLine(" i" + i + " j" + j + " k" + k + " z" + z);
                if ((x[2, i] == 0 && x[3, j] == 0) && (x[4, k] == 0 && x[5, z] == 0))
                {

                }
                else
                {
                    if (((x[2, i] == x[3, j]) && (x[4, k] == x[5, z])) && ((x[3, j] == x[4, k]) && (x[2, i] == x[5, z])))
                    {
            //            Console.WriteLine("yesD3");

                        res9 = true;
                    }
                    i += 1; j += 1; k += 1; z += 1;
                }

            }


        }

        return res9;
    }
    private bool compare_D4()
    {
        if (((x[0, 6] == x[1, 5]) && (x[2, 4] == x[3, 3])) && ((x[1, 5] == x[2, 4]) && (x[0, 6] == x[3, 3])) && ((x[0, 6] != 0 && x[1, 5] != 0) && (x[2, 4] != 0 && x[3, 3] != 0)))
        {
            res10 = true;
        //    Console.WriteLine("yesD4.");
        }
        else if (((x[0, 5] == x[1, 4]) && (x[2, 3] == x[3, 2])) && ((x[1, 4] == x[2, 3]) && (x[0, 5] == x[3, 2])) && ((x[0, 5] != 0 && x[1, 4] != 0) && (x[2, 3] != 0 && x[3, 2] != 0)))
        {
            //Console.WriteLine("yesD4.."); 
            res10 = true;
        }
        else if (((x[0, 4] == x[1, 3]) && (x[2, 2] == x[3, 1])) && ((x[1, 3] == x[2, 2]) && (x[0, 4] == x[3, 1])) && ((x[0, 4] != 0 && x[1, 3] != 0) && (x[2, 2] != 0 && x[3, 1] != 0)))
        {
            //Console.WriteLine("yesD4...");
            res10 = true;
        }
        else if (((x[0, 3] == x[1, 2]) && (x[2, 1] == x[3, 0])) && ((x[1, 2] == x[2, 1]) && (x[0, 3] == x[3, 0])) && ((x[0, 3] != 0 && x[1, 2] != 0) && (x[2, 1] != 0 && x[3, 0] != 0)))
        {
          //  Console.WriteLine("yesD4....");
            res10 = true;
        }




        /*
        int i = 6, j = 5, k = 4, z = 3;

        for (int iter = 0; iter <= 4; iter++)
        {
            if ((i != 2 && j != 1 && k != 0 && z != -1))
            {
                Console.WriteLine("+ i" + i + " j" + j + " k" + k + " z" + z);
                if ((x[0, i] == 0 && x[1, j] == 0) && (x[2, k] == 0 && x[3, z] == 0))
                {

                }
                else
                {
                 //   Console.WriteLine("increment");
                    if (((x[0, i] == x[1, j]) && (x[2, k] == x[3, z])) && ((x[1, j] == x[2, k]) && (x[0, i] == x[3, z])))
                    {
                        Console.WriteLine("yesD4");

                        res6 = true;
                    }
                    i -= 1; j -= 1; k -= 1; z -= 1;
                }

            }
            i -= 1; j -= 1; k -= 1; z -= 1;


        }*/
        return res10;
    }
    private bool compare_D5()
    {
        if (((x[1, 6] == x[2, 5]) && (x[3, 4] == x[4, 3])) && ((x[2, 5] == x[3, 4]) && (x[1, 6] == x[4, 3])) && ((x[1, 6] != 0 && x[2, 5] != 0) && (x[3, 4] != 0 && x[4, 3] != 0)))
        {
   //         Console.WriteLine("yesD5.");
            res11 = true;
        }
        else if (((x[1, 5] == x[2, 4]) && (x[3, 3] == x[4, 2])) && ((x[2, 4] == x[3, 3]) && (x[1, 5] == x[4, 2])) && ((x[1, 5] != 0 && x[2, 4] != 0) && (x[3, 3] != 0 && x[4, 2] != 0)))
        {
            //Console.WriteLine("yesD5.."); 
            res11 = true;
        }
        else if (((x[1, 4] == x[2, 3]) && (x[3, 2] == x[4, 1])) && ((x[2, 3] == x[3, 2]) && (x[1, 4] == x[4, 1])) && ((x[1, 4] != 0 && x[2, 3] != 0) && (x[3, 2] != 0 && x[4, 1] != 0)))
        {
            //Console.WriteLine("yesD5...");
            res11 = true;
        }
        else if (((x[1, 3] == x[2, 2]) && (x[3, 1] == x[4, 0])) && ((x[2, 2] == x[3, 1]) && (x[1, 3] == x[4, 0])) && ((x[1, 3] != 0 && x[2, 2] != 0) && (x[3, 1] != 0 && x[4, 0] != 0)))
        {
            //Console.WriteLine("yesD5...."); 
            res11 = true;
        }

        return res11;

    }
    private bool compare_D6()
    {
        if (((x[2, 6] == x[3, 5]) && (x[4, 4] == x[5, 3])) && ((x[3, 5] == x[4, 4]) && (x[2, 6] == x[5, 3])) && ((x[2, 6] != 0 && x[3, 5] != 0) && (x[4, 4] != 0 && x[5, 3] != 0)))
        {
           // Console.WriteLine("yesD6."); 
            res12 = true;
        }
        else if (((x[2, 5] == x[3, 4]) && (x[4, 3] == x[5, 2])) && ((x[3, 4] == x[4, 3]) && (x[2, 5] == x[5, 2])) && ((x[2, 5] != 0 && x[3, 4] != 0) && (x[4, 3] != 0 && x[5, 2] != 0)))
        {
          //  Console.WriteLine("yesD6.."); 
            res12 = true;
        }
        else if (((x[2, 4] == x[3, 3]) && (x[4, 2] == x[5, 1])) && ((x[3, 3] == x[4, 2]) && (x[2, 4] == x[5, 1])) && ((x[2, 4] != 0 && x[3, 3] != 0) && (x[4, 2] != 0 && x[5, 1] != 0)))
        {
         //   Console.WriteLine("yesD6..."); 
            res12 = true;
        }
        else if (((x[2, 3] == x[3, 2]) && (x[4, 1] == x[5, 0])) && ((x[3, 2] == x[4, 1]) && (x[2, 3] == x[5, 0])) && ((x[2, 3] != 0 && x[3, 2] != 0) && (x[4, 1] != 0 && x[5, 0] != 0)))
        {
         //   Console.WriteLine("yesD6...."); 
            res12 = true;
        }

        /* int i = 6, j = 5, k = 4, z = 3;

         for (int iter = 0; iter <= 4; iter++)
         {
             if ((i != 2 && j != 1 && k != 0 && z != -1))
             {
                 Console.WriteLine("/ i" + i + " j" + j + " k" + k + " z" + z);
                 if ((x[2, i] == 0 && x[3, j] == 0) && (x[4, k] == 0 && x[5, z] == 0))
                 {

                 }
                 else
                 {
                     //   Console.WriteLine("increment");
                     if (((x[1, i] == x[2, j]) && (x[3, k] == x[4, z])) && ((x[2, j] == x[3, k]) && (x[1, i] == x[4, z])))
                     {
                         Console.WriteLine("yesD6");

                         res6 = true;
                     }
                     i -= 1; j -= 1; k -= 1; z -= 1;
                 }

             }
             i -= 1; j -= 1; k -= 1; z -= 1;


         }*/
        return res12;
    }


}
