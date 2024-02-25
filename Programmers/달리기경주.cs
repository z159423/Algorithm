using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        
        Dictionary<string, int> playerPositions = new Dictionary<string, int>();
        for (int i = 0; i < players.Length; i++)
        {
            playerPositions[players[i]] = i;
        }

        foreach (var calling in callings)
        {
            // 호출된 선수의 현재 위치를 찾음
            int currentPosition = playerPositions[calling];
            if (currentPosition > 0) // 맨 앞 선수가 아니라면 (맨 앞 선수는 추월할 수 없음)
            {
                // 추월하여 위치 변경
                string overtakenPlayer = players[currentPosition - 1];
                players[currentPosition - 1] = calling;
                players[currentPosition] = overtakenPlayer;

                // 딕셔너리 업데이트
                playerPositions[calling] = currentPosition - 1;
                playerPositions[overtakenPlayer] = currentPosition;
            }
        }
        
        
        string[] answer = new string[] {};
        
        
        return players;
    }
}