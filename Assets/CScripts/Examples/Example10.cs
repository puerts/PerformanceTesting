﻿using Puerts;
using XLua;

/// <summary>
/// 静态方法调用
/// 逻辑:   无
/// 参数:   一个值类型参数
/// 返回值: 无
/// </summary>
[Test]
[TestGroup("ParameterCompare")]
public class Example10 : IExecute
{
    public bool Static => true;
    public string Method => "void Payload(int);";
    public CallTarget Target => CallTarget.ScriptCallCSharp;

    public object RunCS(int count)
    {
        for (var i = 0; i < count; i++)
        {
            Example10.Payload(i);
        }
        return null;
    }
    public object RunJS(JsEnv env, int count)
    {
        env.Eval(string.Format(
@"
var Example = require('csharp').Example10;
for(let i = 0; i < {0}; i++){{
    Example.Payload(i);
}}
", count));
        return null;
    }
    public object RunLua(LuaEnv env, int count)
    {
        env.DoString(string.Format(
@"
local Example = CS.Example10;
for i = 1,{0} do
    Example.Payload(i);
end
", count));
        return null;
    }

    public static void Payload(int param1)
    {

    }
}
