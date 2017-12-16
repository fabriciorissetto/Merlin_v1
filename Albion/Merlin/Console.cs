﻿using Merlin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;

/// <summary>
/// A console to display Unity's debug logs in-game.
/// </summary>
public class Console : MonoBehaviour
{
    private struct Log
    {
        public string message;
        public string stackTrace;
        public LogType type;
    }

    /// <summary>
    /// The hotkey to show and hide the console window.
    /// </summary>
    public KeyCode toggleKey = KeyCode.BackQuote;

    private List<Log> logs = new List<Log>();
    private Vector2 scrollPosition;
    private bool show;
    private bool collapse;
    private bool scroll = true;
    private bool limit = true;

    // Visual elements:

    private static readonly Dictionary<LogType, Color> logTypeColors = new Dictionary<LogType, Color>()
    {
        { LogType.Assert, Color.white },
        { LogType.Error, Color.red },
        { LogType.Exception, Color.red },
        { LogType.Log, Color.white },
        { LogType.Warning, Color.yellow },
    };

    private const int margin = 20;

    private Rect windowRect = new Rect(margin, margin, Screen.width - (margin * 2), Screen.height - (margin * 2));
    private Rect titleBarRect = new Rect(0, 0, 10000, 20);
    private GUIContent clearLabel = new GUIContent("Clear", "Clear the contents of the console.");
    private GUIContent collapseLabel = new GUIContent("Collapse", "Hide repeated messages.");
    private GUIContent scrollLabel = new GUIContent("Auto scroll", "Scroll automatically.");
    private GUIContent limitLabel = new GUIContent("Limit messages", "Show just the last 200 messages.");

    private void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    private void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    private void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            show = !show;
        }
    }

    private void OnGUI()
    {
        if (!show)
        {
            return;
        }

        windowRect = GUILayout.Window(123456, windowRect, ConsoleWindow, "Console");
    }

    /// <summary>
    /// A window that displayss the recorded logs.
    /// </summary>
    /// <param name="windowID">Window ID.</param>
    private void ConsoleWindow(int windowID)
    {
        scrollPosition = GUILayout.BeginScrollView(scroll ? new Vector2(0, float.MaxValue) : scrollPosition);

        int i = 0;
        if (limit && logs.Count > 200)
            i = logs.Count - 200; // Starts the log in the last 200 messages

        // Iterate through the recorded logs.
        for (; i < logs.Count; i++)
        {
            var log = logs[i];

            // Combine identical messages if collapse option is chosen.
            if (collapse)
            {
                var messageSameAsPrevious = i > 0 && log.message == logs[i - 1].message;

                if (messageSameAsPrevious)
                {
                    continue;
                }
            }

            GUI.contentColor = logTypeColors[log.type];
            GUILayout.Label(log.message);
            if (!string.IsNullOrEmpty(log.stackTrace))
                GUILayout.Label(log.stackTrace);
        }

        GUILayout.EndScrollView();

        GUI.contentColor = Color.white;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button(clearLabel))
        {
            logs.Clear();
        }

        collapse = GUILayout.Toggle(collapse, collapseLabel, GUILayout.ExpandWidth(false));
        scroll = GUILayout.Toggle(scroll, scrollLabel, GUILayout.ExpandWidth(false));
        limit = GUILayout.Toggle(limit, limitLabel, GUILayout.ExpandWidth(false));

        GUILayout.EndHorizontal();

        // Allow the window to be dragged by its title bar.
        GUI.DragWindow(titleBarRect);
    }

    /// <summary>
    /// Records a log from the log callback.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="stackTrace">Trace of where the message came from.</param>
    /// <param name="type">Type of message (error, exception, warning, assert).</param>
    private void HandleLog(string message, string stackTrace, LogType type)
    {
        if (message == "a") //Deslogou
        {            
            if (File.Exists("cursor-position.txt"))
            {
                new Thread(() =>
                {
                    for (int i = 0; i < 3; i++)
                    {                        
                        var login = File.ReadAllLines("cursor-position.txt")[0];
                        var enterWorld = File.ReadAllLines("cursor-position.txt")[1];

                        Thread.Sleep(3500);
                        SetCursorPos(Convert.ToInt32(login.Split(',')[0]), Convert.ToInt32(login.Split(',')[1]));
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp | MouseOperations.MouseEventFlags.LeftDown);

                        Thread.Sleep(2500);
                        SetCursorPos(Convert.ToInt32(enterWorld.Split(',')[0]), Convert.ToInt32(enterWorld.Split(',')[1]));
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp | MouseOperations.MouseEventFlags.LeftDown);

                        Thread.Sleep(30000);
                    }
                }).Start();
            } else
            {
                message += " Nao achou o arquivo cursor-position.txt :(";
            }
        }

        if (logs.Count > 100_000)
            logs.RemoveAt(0);

        logs.Add(new Log()
        {
            message = message,
            stackTrace = stackTrace,
            type = type,
        });
    }
}