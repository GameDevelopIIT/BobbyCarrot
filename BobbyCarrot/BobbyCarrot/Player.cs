using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Xna.Framework.Graphics;
using OpenTK;

namespace BobbyCarrot
{
    class Player
    {
        public Texture2D PlayerTexture { get; set; }    //�������� ������
        public Vector2 Position;                        //������� ������
        public int Direction;                           //����������� �������� 
        public int Lives;                               //����� ������ : ����� �� ������!?


        public void Initialize(Texture2D texture)
        {
            this.PlayerTexture = texture;
        }

        public void Update()
        {

        }

        public void Draw()
        {

        }
    }
}