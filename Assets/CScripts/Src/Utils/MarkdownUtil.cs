using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class MarkdownUtil
{
    public static string FromatToTable(List<ExecuteStates> states)
    {
        Func<double, string> FormatDuration =
            (duration) => duration >= 0 ? duration.ToString("f1") : "`fail`";
        Func<object, string> FormatResult =
            (result) => result != null ? result.ToString() : "`null`";
        Func<Type, string> FormatScriptPath = (type) =>
        {
            string scriptPath;
#if UNITY_EDITOR
            string scriptName = $"/{type.Name}.cs";
            scriptPath = UnityEditor.AssetDatabase.GetAllAssetPaths().FirstOrDefault(p => p.EndsWith(scriptName) && UnityEditor.AssetDatabase.GetMainAssetTypeAtPath(p) == typeof(UnityEditor.MonoScript));
#endif

            return scriptPath != null ? $"[#](./{scriptPath})" : "#";
        };


        StringBuilder builder = new StringBuilder();

        builder.Append("| File      | Method    |  Static   | Call      | csDuration(ms)    | jsDuration(ms)    | luaDuration(ms)   | csResult  | jsResult  | luaResult |");
        builder.AppendLine();
        builder.Append("| :----:    | :----     |  :----    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    |");

        foreach (var state in states)
        {
            builder.AppendLine();
            builder.AppendFormat(
                       "| {0}       | {1}       | {2}       | {3}       | {4}       | {5}       | {6}       | {7}       | {8}       | {9}       |",
                FormatScriptPath(state.Type),
                state.Method,
                state.Static ? "√" : "×",
                state.Count,
                FormatDuration(state.CsInvoke.Duration),
                FormatDuration(state.JsInvoke.Duration),
                FormatDuration(state.LuaInvoke.Duration),
                FormatResult(state.CsInvoke.Result),
                FormatResult(state.JsInvoke.Result),
                FormatResult(state.LuaInvoke.Result)
            );
        }

        return builder.ToString();
    }
}