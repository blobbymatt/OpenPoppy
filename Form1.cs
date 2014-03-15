using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace OpenPoppy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int routselect = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Error
        public void Meaning()
        {
            using (StreamWriter streamw = new StreamWriter("Error.txt", true))
            {
                streamw.WriteLine(TxtInput.Text);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //send button
        private void button1_Click(object sender, EventArgs e)
        {

            if (TxtInput.Text != "")
            {
                if (lblpoppy4.Text != "")
                {
                    lblpoppy5.Text = lblpoppy4.Text;
                }
                if (lblpoppy3.Text != "")
                {
                    lblpoppy4.Text = lblpoppy3.Text;
                }
                if (lblpoppy2.Text != "")
                {
                    lblpoppy3.Text = lblpoppy2.Text;
                }
                if (lblpoppy1.Text != "")
                {
                    lblpoppy2.Text = lblpoppy1.Text;
                }
                if (lblyou3.Text != "")
                {
                    lblyou4.Text = lblyou3.Text;
                }
                if (lblyou2.Text != "")
                {
                    lblyou3.Text = lblyou2.Text;
                }
                if (lblyou1.Text != "")
                {
                    lblyou2.Text = lblyou1.Text;
                }

                lblyou1.Text = TxtInput.Text;
            }
            lblpoppy1.Text = "";


            UpdateTextBox();



            TxtInput.Text = "";


        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //rout controler
        public void UpdateTextBox()
        {
            if (routselect == 0)
            {
                //main dialog
                rout0();
            }
            else if (routselect == 1)
            {
                //how are you dialog
                rout1();
            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //main dialog
        public void rout0()
        {
            if (routselect == 0)
            {
                //this is if the user says hello
                if (TxtInput.Text.Contains("hello") || TxtInput.Text.Contains("Hello") || TxtInput.Text.Contains("hi") || TxtInput.Text.Contains("Hi") || TxtInput.Text.Contains("hey") || TxtInput.Text.Contains("Hey") || TxtInput.Text.Contains("Hay") || TxtInput.Text.Contains("hey") || TxtInput.Text.Contains("alright") || TxtInput.Text.Contains("Alright") || TxtInput.Text.Contains("ite") || TxtInput.Text.Contains("Ite"))
                {
                    //the AI ask if your ok

                    lblpoppy1.Text = "How are you?";
                    routselect = 1;
                }


            //ask if the AI is hungry
                else if (TxtInput.Text.Contains("Are you hungry") || TxtInput.Text.Contains("Hungry") || TxtInput.Text.Contains("Do you hungery") || TxtInput.Text.Contains("Do you want something to eat") || TxtInput.Text.Contains("are you hungry") || TxtInput.Text.Contains("hungry") || TxtInput.Text.Contains("do you hungery") || TxtInput.Text.Contains("do you want something to eat") || TxtInput.Text.Contains("Are you hungry?") || TxtInput.Text.Contains("Hungry?") || TxtInput.Text.Contains("Do you hungery?") || TxtInput.Text.Contains("Do you want something to eat?") || TxtInput.Text.Contains("are you hungry?") || TxtInput.Text.Contains("hungry?") || TxtInput.Text.Contains("do you hungery?") || TxtInput.Text.Contains("do you want something to eat?"))
                {

                    lblpoppy1.Text = "No but if your hungery go get something too eat";


                }
                //ask what the AI is doing
                else if (TxtInput.Text.Contains("What are you doing") || TxtInput.Text.Contains("what are you doing") || TxtInput.Text.Contains("Wuu2") || TxtInput.Text.Contains("wuu2") || TxtInput.Text.Contains("What you doing") || TxtInput.Text.Contains("what you doing") || TxtInput.Text.Contains("What are you up to") || TxtInput.Text.Contains("what are you up to") || TxtInput.Text.Contains("What you up to") || TxtInput.Text.Contains("what you up to") || TxtInput.Text.Contains("What are you doing?") || TxtInput.Text.Contains("what are you doing?") || TxtInput.Text.Contains("Wuu2?") || TxtInput.Text.Contains("wuu2?") || TxtInput.Text.Contains("What you doing?") || TxtInput.Text.Contains("what you doing?") || TxtInput.Text.Contains("What are you up to?") || TxtInput.Text.Contains("what are you up to?") || TxtInput.Text.Contains("What you up to?") || TxtInput.Text.Contains("what you up to?"))
                {
                    //AI asks what your doing
                    lblpoppy1.Text = "Talking to you, What are you doing? ";
                    //######################################################################################################
                    if (TxtInput.Text.Contains("nothing") || TxtInput.Text.Contains("nothing much") || TxtInput.Text.Contains("Nothing") || TxtInput.Text.Contains("Nothing much") || TxtInput.Text.Contains("nothing at all") || TxtInput.Text.Contains("Nothing at all") || TxtInput.Text.Contains("nm") || TxtInput.Text.Contains("not much") || TxtInput.Text.Contains("Not much"))
                    {

                        lblpoppy1.Text = "so your not talking to me";
                    }
                    else
                    {

                        lblpoppy1.Text = "Sounds like fun";


                    }
                }
                // ask the AI how they are
                else if (TxtInput.Text.Contains("who are you") || TxtInput.Text.Contains("who are you?") || TxtInput.Text.Contains("Who are you?") || TxtInput.Text.Contains("Who are you") || TxtInput.Text.Contains("what is your name?") || TxtInput.Text.Contains("What is your name?") || TxtInput.Text.Contains("what is your name") || TxtInput.Text.Contains("What is your name") || TxtInput.Text.Contains("Do you have a name?") || TxtInput.Text.Contains("do you have a name?") || TxtInput.Text.Contains("Do you have a name") || TxtInput.Text.Contains("do you have a name") || TxtInput.Text.Contains("whats your name?") || TxtInput.Text.Contains("Whats your name?") || TxtInput.Text.Contains("whats your name") || TxtInput.Text.Contains("Whats your name") || TxtInput.Text.Contains("what are you called?") || TxtInput.Text.Contains("What are you called?") || TxtInput.Text.Contains("what are you called") || TxtInput.Text.Contains("what are you called"))
                {

                    lblpoppy1.Text = "My name is Poppy";


                }
                //responce thanks
                else if (TxtInput.Text.Contains("Thanks") || TxtInput.Text.Contains("thanks") || TxtInput.Text.Contains("Thankyou") || TxtInput.Text.Contains("thankyou") || TxtInput.Text.Contains("Thank you") || TxtInput.Text.Contains("thank you"))
                {

                    lblpoppy1.Text = "No, thank you";


                }
                // tell the AI somthing is good
                else if (TxtInput.Text.Contains("thats good") || TxtInput.Text.Contains("thats great") || TxtInput.Text.Contains("good") || TxtInput.Text.Contains("im glad") || TxtInput.Text.Contains("brilliant") || TxtInput.Text.Contains("cool") || TxtInput.Text.Contains("epic") || TxtInput.Text.Contains("fabulous") || TxtInput.Text.Contains("groovy") || TxtInput.Text.Contains("impressive") || TxtInput.Text.Contains("incredible") || TxtInput.Text.Contains("ingenious") || TxtInput.Text.Contains("out of this world") || TxtInput.Text.Contains("overwhelming") || TxtInput.Text.Contains("sweet") || TxtInput.Text.Contains("wonderful") || TxtInput.Text.Contains("thats brilliant") || TxtInput.Text.Contains("thats cool") || TxtInput.Text.Contains("thats epic") || TxtInput.Text.Contains("thats fabulous") || TxtInput.Text.Contains("thats groovy") || TxtInput.Text.Contains("thats impressive") || TxtInput.Text.Contains("thats incredible") || TxtInput.Text.Contains("thats ingenious") || TxtInput.Text.Contains("thats out of this world") || TxtInput.Text.Contains("thats overwhelming") || TxtInput.Text.Contains("thats sweet") || TxtInput.Text.Contains("thats wonderful") || TxtInput.Text.Contains("Thats brilliant") || TxtInput.Text.Contains("Thats cool") || TxtInput.Text.Contains("Thats epic") || TxtInput.Text.Contains("Thats fabulous") || TxtInput.Text.Contains("Thats groovy") || TxtInput.Text.Contains("Thats impressive") || TxtInput.Text.Contains("Thats incredible") || TxtInput.Text.Contains("Thats ingenious") || TxtInput.Text.Contains("Thats out of this world") || TxtInput.Text.Contains("Thats overwhelming") || TxtInput.Text.Contains("Thats sweet") || TxtInput.Text.Contains("Thats wonderful"))
                {

                    lblpoppy1.Text = "Thank you";


                }
                //awnsers that requier the resopnce ok
                else if ((TxtInput.Text.Contains("Where") && TxtInput.Text.Contains("live")) || (TxtInput.Text.Contains("where") && TxtInput.Text.Contains("live")) || TxtInput.Text.Contains("Anytime") || TxtInput.Text.Contains("Any time") || TxtInput.Text.Contains("anytime") || TxtInput.Text.Contains("any time") || TxtInput.Text.Contains("Neither do i") || TxtInput.Text.Contains("neither do i") || TxtInput.Text.Contains("I will") || TxtInput.Text.Contains("i will") || TxtInput.Text.Contains("Not really") || TxtInput.Text.Contains("not really") || TxtInput.Text.Contains("dont worry about it") || TxtInput.Text.Contains("its ok") || TxtInput.Text.Contains("not to worry") || TxtInput.Text.Contains("dont worry") || TxtInput.Text.Contains("Dont worry about it") || TxtInput.Text.Contains("Its ok") || TxtInput.Text.Contains("Not to worry") || TxtInput.Text.Contains("Dont worry"))
                {

                    lblpoppy1.Text = "ok";


                }
                //question to ask where the AI is from
                else if (TxtInput.Text.Contains("where where you born") || TxtInput.Text.Contains("where are you from") || TxtInput.Text.Contains("where do you come from") || TxtInput.Text.Contains("Where where you born") || TxtInput.Text.Contains("Where are you from") || TxtInput.Text.Contains("Where do you come from") || TxtInput.Text.Contains("where where you born?") || TxtInput.Text.Contains("where are you from?") || TxtInput.Text.Contains("where do you come from?") || TxtInput.Text.Contains("Where where you born?") || TxtInput.Text.Contains("Where are you from?") || TxtInput.Text.Contains("Where do you come from?"))
                {

                    lblpoppy1.Text = "i was born in sunderland, england";


                }
                //question where do you live
                else if (TxtInput.Text.Contains("where do you live") || TxtInput.Text.Contains("what is you place of residence") || TxtInput.Text.Contains("where do you reside") || TxtInput.Text.Contains("where are you") || TxtInput.Text.Contains("Where do you live") || TxtInput.Text.Contains("What is you place of residence") || TxtInput.Text.Contains("Where do you reside") || TxtInput.Text.Contains("Where are you") || TxtInput.Text.Contains("where do you live?") || TxtInput.Text.Contains("what is you place of residence?") || TxtInput.Text.Contains("where do you reside?") || TxtInput.Text.Contains("where are you?") || TxtInput.Text.Contains("Where do you live?") || TxtInput.Text.Contains("What is you place of residence?") || TxtInput.Text.Contains("Where do you reside?") || TxtInput.Text.Contains("Where are you?"))
                {

                    lblpoppy1.Text = "i live in sunderland, england";


                }
                //question are you alive
                else if (TxtInput.Text.Contains("are you human") || TxtInput.Text.Contains("are you a computer") || TxtInput.Text.Contains("are you real") || TxtInput.Text.Contains("are you a robot") || TxtInput.Text.Contains("are you living") || TxtInput.Text.Contains("are you alive") || TxtInput.Text.Contains("are you human?") || TxtInput.Text.Contains("are you a computer?") || TxtInput.Text.Contains("are you real?") || TxtInput.Text.Contains("are you a robot?") || TxtInput.Text.Contains("are you living?") || TxtInput.Text.Contains("are you alive?") || TxtInput.Text.Contains("Are you human") || TxtInput.Text.Contains("Are you a computer") || TxtInput.Text.Contains("Are you real") || TxtInput.Text.Contains("Are you a robot") || TxtInput.Text.Contains("Are you living") || TxtInput.Text.Contains("Are you alive") || TxtInput.Text.Contains("Are you human?") || TxtInput.Text.Contains("Are you a computer?") || TxtInput.Text.Contains("Are you real?") || TxtInput.Text.Contains("Are you a robot?") || TxtInput.Text.Contains("Are you living?") || TxtInput.Text.Contains("Are you alive?"))
                {

                    lblpoppy1.Text = "I'm just as alive as you are";


                }
                //question how are you 
                else if (TxtInput.Text.Contains("how are you") || TxtInput.Text.Contains("are you ok") || TxtInput.Text.Contains("how are you doing") || TxtInput.Text.Contains("how are you feeling") || TxtInput.Text.Contains("r u ok") || TxtInput.Text.Contains("how are you?") || TxtInput.Text.Contains("are you ok?") || TxtInput.Text.Contains("how are you doing?") || TxtInput.Text.Contains("how are you feeling?") || TxtInput.Text.Contains("r u ok?") || TxtInput.Text.Contains("How are you") || TxtInput.Text.Contains("Are you ok") || TxtInput.Text.Contains("How are you doing") || TxtInput.Text.Contains("How are you feeling") || TxtInput.Text.Contains("R u ok") || TxtInput.Text.Contains("How are you?") || TxtInput.Text.Contains("Are you ok?") || TxtInput.Text.Contains("How are you doing?") || TxtInput.Text.Contains("How are you feeling?") || TxtInput.Text.Contains("R u ok?"))
                {

                    lblpoppy1.Text = "I'm excellent, thanks for asking";


                }
                //question fav colour
                else if (TxtInput.Text.Contains("Whats your favourite colour") || TxtInput.Text.Contains("What is your favourite colour?") || TxtInput.Text.Contains("what is your favourite colour?") || TxtInput.Text.Contains("what is your favourite colour") || TxtInput.Text.Contains("whats your favourite colour") || TxtInput.Text.Contains("what colour do you like") || TxtInput.Text.Contains("what colour do you like the most") || TxtInput.Text.Contains("what colour do you like the most") || TxtInput.Text.Contains("whats your favourite colour") || TxtInput.Text.Contains("what's your favourite colour") || TxtInput.Text.Contains("favourite colour") || TxtInput.Text.Contains("whats your favourite colour?") || TxtInput.Text.Contains("what colour do you like?") || TxtInput.Text.Contains("what colour do you like the most?") || TxtInput.Text.Contains("what colour do you like the most?") || TxtInput.Text.Contains("whats your favourite colour?") || TxtInput.Text.Contains("what's your favourite colour?") || TxtInput.Text.Contains("favourite colour?") || TxtInput.Text.Contains("Whats your favourite colour") || TxtInput.Text.Contains("What colour do you like") || TxtInput.Text.Contains("What colour do you like the most") || TxtInput.Text.Contains("What colour do you like the most") || TxtInput.Text.Contains("Whats your favourite colour") || TxtInput.Text.Contains("What's your favourite colour") || TxtInput.Text.Contains("Favourite colour") || TxtInput.Text.Contains("Whats your favourite colour?") || TxtInput.Text.Contains("What colour do you like?") || TxtInput.Text.Contains("What colour do you like the most?") || TxtInput.Text.Contains("What colour do you like the most?") || TxtInput.Text.Contains("Whats your favourite colour?") || TxtInput.Text.Contains("What's your favourite colour?") || TxtInput.Text.Contains("Favourite colour?") || TxtInput.Text.Contains("do you have a favouite colour") || TxtInput.Text.Contains("do you have a favouite colour?") || TxtInput.Text.Contains("Do you have a favouite colour") || TxtInput.Text.Contains("Do you have a favouite colour?"))
                {

                    lblpoppy1.Text = "Red, after my name. Do you have a favorite colour?";




                }
                //question fav film
                else if (TxtInput.Text.Contains("What is your favourite film") || TxtInput.Text.Contains("What is your favourite film?") || TxtInput.Text.Contains("what is your favourite film?") || TxtInput.Text.Contains("what is your favourite film") || TxtInput.Text.Contains("whats your favourite film") || TxtInput.Text.Contains("what film do you like") || TxtInput.Text.Contains("what film do you like the most") || TxtInput.Text.Contains("what film do you like the most") || TxtInput.Text.Contains("whats your favourite film") || TxtInput.Text.Contains("what's your favourite film") || TxtInput.Text.Contains("favourite film") || TxtInput.Text.Contains("whats your favourite film?") || TxtInput.Text.Contains("what film do you like?") || TxtInput.Text.Contains("what film do you like the most?") || TxtInput.Text.Contains("what film do you like the most?") || TxtInput.Text.Contains("whats your favourite film?") || TxtInput.Text.Contains("what's your favourite film?") || TxtInput.Text.Contains("favourite film?") || TxtInput.Text.Contains("Whats your favourite film") || TxtInput.Text.Contains("What film do you like") || TxtInput.Text.Contains("What film do you like the most") || TxtInput.Text.Contains("What film do you like the most") || TxtInput.Text.Contains("Whats your favourite film") || TxtInput.Text.Contains("What's your favourite film") || TxtInput.Text.Contains("Favourite film") || TxtInput.Text.Contains("Whats your favourite film?") || TxtInput.Text.Contains("What film do you like?") || TxtInput.Text.Contains("What film do you like the most?") || TxtInput.Text.Contains("What film do you like the most?") || TxtInput.Text.Contains("Whats your favourite film?") || TxtInput.Text.Contains("What's your favourite film?") || TxtInput.Text.Contains("Favourite film?") || TxtInput.Text.Contains("do you have a favouite film?") || TxtInput.Text.Contains("do you have a favouite film") || TxtInput.Text.Contains("Do you have a favouite film?") || TxtInput.Text.Contains("do you have a favouite film"))
                {

                    lblpoppy1.Text = "matrix, I like the idea of machines taking over. what is your favorite film?";




                }
                //hungry
                else if (TxtInput.Text.Contains("i am hungry") || TxtInput.Text.Contains("I am hungry") || TxtInput.Text.Contains("Im hungry") || TxtInput.Text.Contains("im hungry") || TxtInput.Text.Contains("I'm hungry") || TxtInput.Text.Contains("i'm hungry") || TxtInput.Text.Contains("I want food") || TxtInput.Text.Contains("i want food"))
                {

                    lblpoppy1.Text = "Go get something to eat then";


                }
                // play game
                else if (TxtInput.Text.Contains("what do you want to do") || TxtInput.Text.Contains("do you want to do something") || TxtInput.Text.Contains("im bored") || TxtInput.Text.Contains("i'm bored") || TxtInput.Text.Contains("bored") || TxtInput.Text.Contains("can we do something") || TxtInput.Text.Contains("im bored lets do something") || TxtInput.Text.Contains("i'm bored lets do something") || TxtInput.Text.Contains("i'm bored, lets do something") || TxtInput.Text.Contains("im bored, lets do something") || TxtInput.Text.Contains("im bored do you want to do something") || TxtInput.Text.Contains("im bored, do you want to do something") || TxtInput.Text.Contains("i'm bored, do you want to do something") || TxtInput.Text.Contains("what do you want to do?") || TxtInput.Text.Contains("do you want to do something?") || TxtInput.Text.Contains("im bored?") || TxtInput.Text.Contains("i'm bored?") || TxtInput.Text.Contains("bored?") || TxtInput.Text.Contains("can we do something?") || TxtInput.Text.Contains("im bored lets do something?") || TxtInput.Text.Contains("i'm bored lets do something?") || TxtInput.Text.Contains("i'm bored, lets do something?") || TxtInput.Text.Contains("im bored, lets do something?") || TxtInput.Text.Contains("im bored do you want to do something?") || TxtInput.Text.Contains("im bored, do you want to do something?") || TxtInput.Text.Contains("i'm bored, do you want to do something?") || TxtInput.Text.Contains("What do you want to do") || TxtInput.Text.Contains("Do you want to do something") || TxtInput.Text.Contains("Im bored") || TxtInput.Text.Contains("I'm bored") || TxtInput.Text.Contains("Bored") || TxtInput.Text.Contains("Can we do something") || TxtInput.Text.Contains("Im bored lets do something") || TxtInput.Text.Contains("I'm bored lets do something") || TxtInput.Text.Contains("I'm bored, lets do something") || TxtInput.Text.Contains("Im bored, lets do something") || TxtInput.Text.Contains("Im bored do you want to do something") || TxtInput.Text.Contains("Im bored, do you want to do something") || TxtInput.Text.Contains("I'm bored, do you want to do something") || TxtInput.Text.Contains("What do you want to do?") || TxtInput.Text.Contains("Do you want to do something?") || TxtInput.Text.Contains("Im bored?") || TxtInput.Text.Contains("I'm bored?") || TxtInput.Text.Contains("Bored?") || TxtInput.Text.Contains("Can we do something?") || TxtInput.Text.Contains("Im bored lets do something?") || TxtInput.Text.Contains("I'm bored lets do something?") || TxtInput.Text.Contains("I'm bored, lets do something?") || TxtInput.Text.Contains("Im bored, lets do something?") || TxtInput.Text.Contains("Im bored do you want to do something?") || TxtInput.Text.Contains("Im bored, do you want to do something?") || TxtInput.Text.Contains("I'm bored, do you want to do something?"))
                {
                    /////////////////////////////////////////////////////////////////////// 

                }
                //what do you like
                else if ((TxtInput.Text.Contains("what") && TxtInput.Text.Contains("do") && TxtInput.Text.Contains("you") && TxtInput.Text.Contains("like")) || (TxtInput.Text.Contains("What") && TxtInput.Text.Contains("do") && TxtInput.Text.Contains("you") && TxtInput.Text.Contains("like")))
                {

                    lblpoppy1.Text = "I like many things";


                }
                // question do you like......
                else if ((TxtInput.Text.Contains("do") && TxtInput.Text.Contains("you") && TxtInput.Text.Contains("like")) || (TxtInput.Text.Contains("Do") && TxtInput.Text.Contains("you") && TxtInput.Text.Contains("like")) || (TxtInput.Text.Contains("Do") && TxtInput.Text.Contains("you") && TxtInput.Text.Contains("love")))
                {

                    lblpoppy1.Text = "Yes i do, " + TxtInput.Text;



                }
                //question did you know......
                else if ((TxtInput.Text.Contains("did") && TxtInput.Text.Contains("you") && TxtInput.Text.Contains("know")) || (TxtInput.Text.Contains("Did") && TxtInput.Text.Contains("you") && TxtInput.Text.Contains("know")))
                {

                    lblpoppy1.Text = "No i did not, can you tell me more about it";




                }
                // know where
                else if ((TxtInput.Text.Contains("Know") && TxtInput.Text.Contains("where")) || (TxtInput.Text.Contains("know") && TxtInput.Text.Contains("where")))
                {

                    lblpoppy1.Text = "I'm sorry i dont. i wish i could help";


                }
                // know where
                else if ((TxtInput.Text.Contains("want") && TxtInput.Text.Contains("drink")) || (TxtInput.Text.Contains("Want") && TxtInput.Text.Contains("drink")))
                {

                    lblpoppy1.Text = "I'm not thirsty, Thank you";


                }
                //have you seen
                else if ((TxtInput.Text.Contains("you") && TxtInput.Text.Contains("seen")) || (TxtInput.Text.Contains("You") && TxtInput.Text.Contains("seen")))
                {

                    lblpoppy1.Text = "No i havent, is it good?";
                    //###########################################################################################################

                    if (TxtInput.Text.Contains("yes") || TxtInput.Text.Contains("ye") || TxtInput.Text.Contains("ya") || TxtInput.Text.Contains("ok") || TxtInput.Text.Contains("OK") || TxtInput.Text.Contains("Yes") || TxtInput.Text.Contains("Ye") || TxtInput.Text.Contains("Ya"))
                    {

                        lblpoppy1.Text = "I might go see it";


                    }
                    else
                    {

                        lblpoppy1.Text = "Ok, I wont watch that";
                    }
                }
                //do you want
                else if ((TxtInput.Text.Contains("you") && TxtInput.Text.Contains("want")) || (TxtInput.Text.Contains("You") && TxtInput.Text.Contains("want")))
                {

                    lblpoppy1.Text = "No thank you, but you can";


                }
                //anything that needs the responece good
                else if (TxtInput.Text.Contains("it is") || TxtInput.Text.Contains("it is fun") || TxtInput.Text.Contains("It is") || TxtInput.Text.Contains("It is fun"))
                {

                    lblpoppy1.Text = "Good";


                }
                //what do you think
                else if ((TxtInput.Text.Contains("What") && TxtInput.Text.Contains("you") && TxtInput.Text.Contains("think")) || (TxtInput.Text.Contains("what") && TxtInput.Text.Contains("you") && TxtInput.Text.Contains("think")) || (TxtInput.Text.Contains("feel") && TxtInput.Text.Contains("about")) || (TxtInput.Text.Contains("Feel") && TxtInput.Text.Contains("about")))
                {

                    lblpoppy1.Text = "I like it," + TxtInput.Text;
                    //##########################################################################################################
                    if (TxtInput.Text.Contains("like") || TxtInput.Text.Contains("love") || TxtInput.Text.Contains("good") || TxtInput.Text.Contains("great"))
                    {

                        lblpoppy1.Text = "Im glad we are on the same page";


                    }
                    else
                    {

                        lblpoppy1.Text = "oh ok";


                    }
                }
                //if AI dosent know what your saying it says
                else
                {

                    lblpoppy1.Text = "What do you mean ";
                    Meaning();

                }


            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //diolog after the AI asks how you are
        public void rout1()
        {


            // awnser that you are good and ask if the AI is ok
            if (TxtInput.Text.Contains("acceptable you?") || TxtInput.Text.Contains("exellent you?") || TxtInput.Text.Contains("exceptional you?") || TxtInput.Text.Contains("favorable you?") || TxtInput.Text.Contains("marvelous you?") || TxtInput.Text.Contains("satisfactory you?") || TxtInput.Text.Contains("superb you?") || TxtInput.Text.Contains("rad you?") || TxtInput.Text.Contains("wonderful you?") || TxtInput.Text.Contains("sound you?") || TxtInput.Text.Contains("stupendous you?") || TxtInput.Text.Contains("tip-top you?") || TxtInput.Text.Contains("tip top you?") || TxtInput.Text.Contains("awsome, you") || TxtInput.Text.Contains("Acceptable you?") || TxtInput.Text.Contains("Exellent you?") || TxtInput.Text.Contains("Exceptional you?") || TxtInput.Text.Contains("Favorable you?") || TxtInput.Text.Contains("Marvelous you?") || TxtInput.Text.Contains("Satisfactory you?") || TxtInput.Text.Contains("Superb you?") || TxtInput.Text.Contains("Rad you?") || TxtInput.Text.Contains("Wonderful you?") || TxtInput.Text.Contains("Sound you?") || TxtInput.Text.Contains("Stupendous you?") || TxtInput.Text.Contains("Tip-top you?") || TxtInput.Text.Contains("Tip top you?") || TxtInput.Text.Contains("Awsome, you") || TxtInput.Text.Contains("acceptable, you?") || TxtInput.Text.Contains("exellent, you?") || TxtInput.Text.Contains("exceptional, you?") || TxtInput.Text.Contains("favorable, you?") || TxtInput.Text.Contains("marvelous, you?") || TxtInput.Text.Contains("satisfactory, you?") || TxtInput.Text.Contains("superb, you?") || TxtInput.Text.Contains("rad, you?") || TxtInput.Text.Contains("wonderful, you?") || TxtInput.Text.Contains("sound, you?") || TxtInput.Text.Contains("stupendous, you?") || TxtInput.Text.Contains("tip-top, you?") || TxtInput.Text.Contains("tip top, you?") || TxtInput.Text.Contains("Acceptable, you?") || TxtInput.Text.Contains("Exellent, you?") || TxtInput.Text.Contains("Exceptional, you?") || TxtInput.Text.Contains("Favorable, you?") || TxtInput.Text.Contains("Marvelous, you?") || TxtInput.Text.Contains("Satisfactory, you?") || TxtInput.Text.Contains("Superb, you?") || TxtInput.Text.Contains("Rad, you?") || TxtInput.Text.Contains("Wonderful, you?") || TxtInput.Text.Contains("Sound, you?") || TxtInput.Text.Contains("Stupendous, you?") || TxtInput.Text.Contains("Tip-top, you?") || TxtInput.Text.Contains("Tip top, you?") || TxtInput.Text.Contains("awsome, you?") || TxtInput.Text.Contains("Awsome, you?") || TxtInput.Text.Contains("awsome you?") || TxtInput.Text.Contains("awsome, you") || TxtInput.Text.Contains("Awsome, you") || TxtInput.Text.Contains("Awsome you") || TxtInput.Text.Contains("acceptable you") || TxtInput.Text.Contains("exellent you") || TxtInput.Text.Contains("exceptional you") || TxtInput.Text.Contains("favorable you") || TxtInput.Text.Contains("marvelous you") || TxtInput.Text.Contains("satisfactory you") || TxtInput.Text.Contains("superb you") || TxtInput.Text.Contains("rad you") || TxtInput.Text.Contains("wonderful you") || TxtInput.Text.Contains("sound you") || TxtInput.Text.Contains("stupendous you") || TxtInput.Text.Contains("tip-top you") || TxtInput.Text.Contains("tip top you") || TxtInput.Text.Contains("Acceptable you") || TxtInput.Text.Contains("Exellent you") || TxtInput.Text.Contains("Exceptional you") || TxtInput.Text.Contains("Favorable you") || TxtInput.Text.Contains("Marvelous you") || TxtInput.Text.Contains("Satisfactory you") || TxtInput.Text.Contains("Superb you") || TxtInput.Text.Contains("Rad you") || TxtInput.Text.Contains("Wonderful you") || TxtInput.Text.Contains("Sound you") || TxtInput.Text.Contains("Stupendous you") || TxtInput.Text.Contains("Tip-top you") || TxtInput.Text.Contains("Tip top you") || TxtInput.Text.Contains("acceptable, you") || TxtInput.Text.Contains("exellent, you") || TxtInput.Text.Contains("exceptional, you") || TxtInput.Text.Contains("favorable, you") || TxtInput.Text.Contains("marvelous, you") || TxtInput.Text.Contains("satisfactory, you") || TxtInput.Text.Contains("superb, you") || TxtInput.Text.Contains("rad, you") || TxtInput.Text.Contains("wonderful, you") || TxtInput.Text.Contains("sound, you") || TxtInput.Text.Contains("stupendous, you") || TxtInput.Text.Contains("tip-top, you") || TxtInput.Text.Contains("tip top, you") || TxtInput.Text.Contains("Acceptable, you") || TxtInput.Text.Contains("Exellent, you") || TxtInput.Text.Contains("Exceptional, you") || TxtInput.Text.Contains("Favorable, you") || TxtInput.Text.Contains("Marvelous, you") || TxtInput.Text.Contains("Satisfactory, you") || TxtInput.Text.Contains("Superb, you") || TxtInput.Text.Contains("Rad, you") || TxtInput.Text.Contains("Wonderful, you") || TxtInput.Text.Contains("Sound, you") || TxtInput.Text.Contains("Stupendous, you") || TxtInput.Text.Contains("Tip-top, you") || TxtInput.Text.Contains("Tip top, you") || TxtInput.Text.Contains("acceptable how are you?") || TxtInput.Text.Contains("exellent how are you?") || TxtInput.Text.Contains("exceptional how are you?") || TxtInput.Text.Contains("favorable how are you?") || TxtInput.Text.Contains("marvelous how are you?") || TxtInput.Text.Contains("satisfactory how are you?") || TxtInput.Text.Contains("superb how are you?") || TxtInput.Text.Contains("rad how are you?") || TxtInput.Text.Contains("wonderful how are you?") || TxtInput.Text.Contains("sound how are you?") || TxtInput.Text.Contains("stupendous how are you?") || TxtInput.Text.Contains("tip-top how are you?") || TxtInput.Text.Contains("tip top how are you?") || TxtInput.Text.Contains("Acceptable how are you?") || TxtInput.Text.Contains("Exellent how are you?") || TxtInput.Text.Contains("Exceptional how are you?") || TxtInput.Text.Contains("Favorable how are you?") || TxtInput.Text.Contains("Marvelous how are you?") || TxtInput.Text.Contains("Satisfactory how are you?") || TxtInput.Text.Contains("Superb how are you?") || TxtInput.Text.Contains("Rad how are you?") || TxtInput.Text.Contains("Wonderful how are you?") || TxtInput.Text.Contains("Sound how are you?") || TxtInput.Text.Contains("Stupendous how are you?") || TxtInput.Text.Contains("Tip-top how are you?") || TxtInput.Text.Contains("Tip top how are you?") || TxtInput.Text.Contains("acceptable, how are you?") || TxtInput.Text.Contains("exellent, how are you?") || TxtInput.Text.Contains("exceptional, how are you?") || TxtInput.Text.Contains("favorable, how are you?") || TxtInput.Text.Contains("marvelous, how are you?") || TxtInput.Text.Contains("satisfactory, how are you?") || TxtInput.Text.Contains("superb, how are you?") || TxtInput.Text.Contains("rad, how are you?") || TxtInput.Text.Contains("wonderful, how are you?") || TxtInput.Text.Contains("sound, how are you?") || TxtInput.Text.Contains("stupendous, how are you?") || TxtInput.Text.Contains("tip-top, how are you?") || TxtInput.Text.Contains("tip top, how are you?") || TxtInput.Text.Contains("Acceptable, how are you?") || TxtInput.Text.Contains("Exellent, how are you?") || TxtInput.Text.Contains("Exceptional, how are you?") || TxtInput.Text.Contains("Favorable, how are you?") || TxtInput.Text.Contains("Marvelous, how are you?") || TxtInput.Text.Contains("Satisfactory, how are you?") || TxtInput.Text.Contains("Superb, how are you?") || TxtInput.Text.Contains("Rad, how are you?") || TxtInput.Text.Contains("Wonderful, how are you?") || TxtInput.Text.Contains("Sound, how are you?") || TxtInput.Text.Contains("Stupendous, how are you?") || TxtInput.Text.Contains("Tip-top, how are you?") || TxtInput.Text.Contains("Tip top, how are you?") || TxtInput.Text.Contains("acceptable how are you") || TxtInput.Text.Contains("exellent how are you") || TxtInput.Text.Contains("exceptional how are you") || TxtInput.Text.Contains("favorable how are you") || TxtInput.Text.Contains("marvelous how are you") || TxtInput.Text.Contains("satisfactory how are you") || TxtInput.Text.Contains("superb how are you") || TxtInput.Text.Contains("rad how are you") || TxtInput.Text.Contains("wonderful how are you") || TxtInput.Text.Contains("sound how are you") || TxtInput.Text.Contains("stupendous how are you") || TxtInput.Text.Contains("tip-top how are you") || TxtInput.Text.Contains("tip top how are you") || TxtInput.Text.Contains("Acceptable how are you") || TxtInput.Text.Contains("Exellent how are you") || TxtInput.Text.Contains("Exceptional how are you") || TxtInput.Text.Contains("Favorable how are you") || TxtInput.Text.Contains("Marvelous how are you") || TxtInput.Text.Contains("Satisfactory how are you") || TxtInput.Text.Contains("Superb how are you") || TxtInput.Text.Contains("Rad how are you") || TxtInput.Text.Contains("Wonderful how are you") || TxtInput.Text.Contains("Sound how are you") || TxtInput.Text.Contains("Stupendous how are you") || TxtInput.Text.Contains("Tip-top how are you") || TxtInput.Text.Contains("Tip top how are you") ||
TxtInput.Text.Contains("Good thanks, you") || TxtInput.Text.Contains("Good thanks you?") || TxtInput.Text.Contains("good thanks, you?") || TxtInput.Text.Contains("Good thanks you") || TxtInput.Text.Contains("good thanks, you") || TxtInput.Text.Contains("good thanks you?") || TxtInput.Text.Contains("good thanks you") || TxtInput.Text.Contains("I am good how are you") || TxtInput.Text.Contains("I'm good you?") || TxtInput.Text.Contains("i'm good you?") || TxtInput.Text.Contains("im good, you?") || TxtInput.Text.Contains("Im good, you?") || TxtInput.Text.Contains("Im good you?") || TxtInput.Text.Contains("im good you?") || TxtInput.Text.Contains("Good, what about you?") || TxtInput.Text.Contains("good, what about you?") || TxtInput.Text.Contains("I'm good, what about you?") || TxtInput.Text.Contains("I'm good, What about you?") || TxtInput.Text.Contains("Good, you") || TxtInput.Text.Contains("good, you") || TxtInput.Text.Contains("I am good, you?") || TxtInput.Text.Contains("i am good, you?") || TxtInput.Text.Contains("I am good you?") || TxtInput.Text.Contains("i am good you?") || TxtInput.Text.Contains("I am good you") || TxtInput.Text.Contains("i am good you") || TxtInput.Text.Contains("Good, you?") || TxtInput.Text.Contains("good, you?") || TxtInput.Text.Contains("i'm good, you") || TxtInput.Text.Contains("I'm good, you") || TxtInput.Text.Contains("i'm good, you?") || TxtInput.Text.Contains("I'm good, you?") || TxtInput.Text.Contains("good you?") || TxtInput.Text.Contains("Good you?") || TxtInput.Text.Contains("very good you?") || TxtInput.Text.Contains("Very good you?") || TxtInput.Text.Contains("ok you?") || TxtInput.Text.Contains("Ok you?") || TxtInput.Text.Contains("i am very good you?") || TxtInput.Text.Contains("I am very good you?") || TxtInput.Text.Contains("i am verry good you?") || TxtInput.Text.Contains("i am ok you?") || TxtInput.Text.Contains("I am ok you?") || TxtInput.Text.Contains("good how are you?") || TxtInput.Text.Contains("Good how are you?") || TxtInput.Text.Contains("very good how are you?") || TxtInput.Text.Contains("Very good how are you?") || TxtInput.Text.Contains("ok how are you?") || TxtInput.Text.Contains("Ok how are you?") || TxtInput.Text.Contains("i am very good how are you?") || TxtInput.Text.Contains("I am very good how are you?") || TxtInput.Text.Contains("i am verry good how are you?") || TxtInput.Text.Contains("i am ok how are you?") || TxtInput.Text.Contains("I am ok how are you?") || TxtInput.Text.Contains("good what about you?") || TxtInput.Text.Contains("Good what about you?") || TxtInput.Text.Contains("very good what about you?") || TxtInput.Text.Contains("Very good what about you?") || TxtInput.Text.Contains("ok what about you?") || TxtInput.Text.Contains("Ok what about you?") || TxtInput.Text.Contains("i am very good what about you?") || TxtInput.Text.Contains("I am very good what about you?") || TxtInput.Text.Contains("i am verry good what about you?") || TxtInput.Text.Contains("i am ok what about you?") || TxtInput.Text.Contains("I am ok what about you?") || TxtInput.Text.Contains("I am good how are you?") || TxtInput.Text.Contains("I am good, how are you?") || TxtInput.Text.Contains("I am ok what about you"))
            {

                lblpoppy1.Text = "I am glad your ok, i am excellent";
                routselect = 0;

            }

            //awnser that your not good and ask if the AI is ok
            else if ((TxtInput.Text.Contains("atroious") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("awful") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("cheap") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("crummy") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("dreadful") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("lousy") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("poor") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("rough") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("sad") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("unacceptable") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Atroious") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Awful") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Cheap") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Crummy") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Dreadful") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Lousy") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Poor") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Rough") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Sad") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("Unacceptable") && TxtInput.Text.Contains("you")) || (TxtInput.Text.Contains("atroious") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("awful") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("cheap") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("crummy") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("dreadful") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("lousy") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("poor") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("rough") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("sad") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("unacceptable") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Atroious") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Awful") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Cheap") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Crummy") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Dreadful") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Lousy") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Poor") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Rough") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Sad") && TxtInput.Text.Contains("you?")) || (TxtInput.Text.Contains("Unacceptable") && TxtInput.Text.Contains("you?")) || TxtInput.Text.Contains("not good you?") || TxtInput.Text.Contains("bad you?") || TxtInput.Text.Contains("very bad you?") || TxtInput.Text.Contains("i have been better") || TxtInput.Text.Contains("I have been better") || TxtInput.Text.Contains("Not Good You?") || TxtInput.Text.Contains("Not good you?") || TxtInput.Text.Contains("Bad you?") || TxtInput.Text.Contains("Very Bad You?") || TxtInput.Text.Contains("not good what about you?") || TxtInput.Text.Contains("bad what about you?") || TxtInput.Text.Contains("very bad what about you?") || TxtInput.Text.Contains("Not Good What About You?") || TxtInput.Text.Contains("Not good what about you?") || TxtInput.Text.Contains("Bad what about you?") || TxtInput.Text.Contains("Very Bad What About You?") || TxtInput.Text.Contains("not good how are you?") || TxtInput.Text.Contains("bad how are you?") || TxtInput.Text.Contains("very bad how are you?") || TxtInput.Text.Contains("Not Good How Are You?") || TxtInput.Text.Contains("Not good how are you?") || TxtInput.Text.Contains("Bad How Are You?") || TxtInput.Text.Contains("Very Bad How Are You?"))
            {

                lblpoppy1.Text = "OH i hope you feel better soon, but i am excellent";
                routselect = 0;

            }
            //awnser that your not good 
            else if (TxtInput.Text.Contains("atroious") || TxtInput.Text.Contains("awful") || TxtInput.Text.Contains("cheap") || TxtInput.Text.Contains("crummy") || TxtInput.Text.Contains("dreadful") || TxtInput.Text.Contains("lousy") || TxtInput.Text.Contains("poor") || TxtInput.Text.Contains("rough") || TxtInput.Text.Contains("sad") || TxtInput.Text.Contains("unacceptable") || TxtInput.Text.Contains("Atroious") || TxtInput.Text.Contains("Awful") || TxtInput.Text.Contains("Cheap") || TxtInput.Text.Contains("Crummy") || TxtInput.Text.Contains("Dreadful") || TxtInput.Text.Contains("Lousy") || TxtInput.Text.Contains("Poor") || TxtInput.Text.Contains("Rough") || TxtInput.Text.Contains("Sad") || TxtInput.Text.Contains("Unacceptable") || TxtInput.Text.Contains("not good") || TxtInput.Text.Contains("bad") || TxtInput.Text.Contains("very bad") || TxtInput.Text.Contains("Not Good") || TxtInput.Text.Contains("Not good") || TxtInput.Text.Contains("Bad") || TxtInput.Text.Contains("Very Bad"))
            {

                lblpoppy1.Text = "OH i hope you feel better soon";
                routselect = 0;
            }
            //awnser that you are ok
            else if (TxtInput.Text.Contains("acceptable") || TxtInput.Text.Contains("exellent") || TxtInput.Text.Contains("exceptional") || TxtInput.Text.Contains("favorable") || TxtInput.Text.Contains("marvelous") || TxtInput.Text.Contains("satisfactory") || TxtInput.Text.Contains("superb") || TxtInput.Text.Contains("rad") || TxtInput.Text.Contains("wonderful") || TxtInput.Text.Contains("sound") || TxtInput.Text.Contains("stupendous") || TxtInput.Text.Contains("tip-top") || TxtInput.Text.Contains("tip top") || TxtInput.Text.Contains("Acceptable") || TxtInput.Text.Contains("Exellent") || TxtInput.Text.Contains("Exceptional") || TxtInput.Text.Contains("Favorable") || TxtInput.Text.Contains("Marvelous") || TxtInput.Text.Contains("Satisfactory") || TxtInput.Text.Contains("Superb") || TxtInput.Text.Contains("Rad") || TxtInput.Text.Contains("Wonderful") || TxtInput.Text.Contains("Sound") || TxtInput.Text.Contains("Stupendous") || TxtInput.Text.Contains("Tip-top") || TxtInput.Text.Contains("Tip top") || TxtInput.Text.Contains("i am good") || TxtInput.Text.Contains("I am good") || TxtInput.Text.Contains("good") || TxtInput.Text.Contains("Good") || TxtInput.Text.Contains("very good") || TxtInput.Text.Contains("Very good") || TxtInput.Text.Contains("ok") || TxtInput.Text.Contains("Ok") || TxtInput.Text.Contains("i am very good") || TxtInput.Text.Contains("I am very good") || TxtInput.Text.Contains("i am verry good") || TxtInput.Text.Contains("i am ok") || TxtInput.Text.Contains("I am ok") || TxtInput.Text.Contains("i am good") || TxtInput.Text.Contains("I am good") || TxtInput.Text.Contains("I am good, you?"))
            {

                lblpoppy1.Text = "I am glad your ok";
                routselect = 0;

            }
            else
            {

                lblpoppy1.Text = "What do you mean ";
                Meaning();
            }


        }


    }
}



