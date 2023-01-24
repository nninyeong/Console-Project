﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public static class SceneData
    {
        // Title Data
        public static string[] gameTitle = File.ReadAllLines("..\\..\\..\\Title.txt");
        public static string titleOption1 = "1. 게임 시작";
        public static string titleOption2 = "2. 게임 정보";
        public static string titleOption3 = "3. 게임 종료";
        public static string cursorIcon = "▶";


        public const int titleOptionsX = 54;
        public const int titleOption1Y = 15;
        public const int titleOption2Y = 17;
        public const int titleOption3Y = 19;

        public static int preTitleCursorY = 15;
        public static int titleCursorY = 15;

        // GameInfo Data
        public static string[] infos = { "게임인포입니다.", "Title로 돌아가려면 엔터를 누르세요." };

        // InGame Data
        public const int MIN_OF_INGAME_X = 0;
        public const int MAX_OF_INGAME_X = 48;
        public const int MIN_OF_INGAME_Y = 0;
        public const int MAX_OF_INGAME_Y = 19;
    }
}
