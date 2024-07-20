using UnityEngine;
using System;

public static class GameManager
{
    private static int totalKills = 0; // Total de enemigos eliminados
    private static float totalTime = 0f; // Tiempo total jugado en segundos

    public static event Action OnKillsChanged;

    public static int TotalKills
    {
        get { return totalKills; }
        set 
        {
            totalKills = value;
            OnKillsChanged?.Invoke(); // Invocar el evento cuando cambien las bajas
        }
    }

    public static float TotalTime
    {
        get { return totalTime; }
        set { totalTime = value; }
    }

    public static void ResetTotalKills()
    {
        totalKills = 0; // Reinicia el contador de bajas
        OnKillsChanged?.Invoke(); // Invocar el evento al reiniciar las bajas
    }

    public static void ResetTotalTime()
    {
        totalTime = 0f; // Reinicia el tiempo total
    }

    public static void AddKill()
    {
        TotalKills += 1; // Incrementa el contador de bajas
        Debug.Log("Total kills: " + totalKills);
    }

    public static void AddTime(float timeToAdd)
    {
        totalTime += timeToAdd; // Añade tiempo al total
    }

    public static void ResetAll()
    {
        ResetTotalKills();
        ResetTotalTime();
    }
}
