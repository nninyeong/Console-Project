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
        public static string[] gameTitle = File.ReadAllLines("Assets\\Title.txt");
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
        public static string[] infos = File.ReadAllLines("Assets\\GameInfo.txt");

        // InGame Data
        public const int MIN_OF_INGAME_X = 0;
        public const int MAX_OF_INGAME_X = 48;
        public const int MIN_OF_INGAME_Y = 0;
        public const int MAX_OF_INGAME_Y = 19;
        public const int X_OF_DEADCOUNT = 1;
        public const int Y_OF_DEADCOUNT = 25;

        // Ending Data
        public static string[] gifts = { "[ 특별상 ]\n이번달 휴가 7일 추가 제공\n(수령처: 최선문 교수님)", "[ 1등상 ]\n교수님 카드로 구매한 아이스아메리카노\n(수령처: 최선문 교수님)", "[ 2등상 ]\n교수님과 식사권\n(수령처: 최선문 교수님)" };
        public static string[] endInfo = { "-----------------------------------------", "Title로 돌아가려면 엔터를 누르세요.", "게임을 종료하려면 스페이스바를 누르세요.", " " };
    }
}
