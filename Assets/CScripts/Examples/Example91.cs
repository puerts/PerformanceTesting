using Puerts;
using XLua;

/// <summary>
/// 佛波那契数列
/// 逻辑:   无
/// 参数:   无
/// 返回值: 无
/// </summary>
[Test]
public class Example91 : IExecute
{
    public bool Static => true;
    public string Method => "fibonacci(8);";
    public CallTarget Target => CallTarget.ScriptCallScript;

    protected static int fibonacci(int level)
    {
        if (level == 0) return 0;
        if (level == 1) return 1;
        return fibonacci(level - 1) + fibonacci(level - 2);
    }

    public object RunCS(int count, out double duration)
    {
        Timer timer = new Timer();
        long sum = 0;
        for (var i = 0; i < count; i++)
        {
            sum += fibonacci(8);
        }
        duration = timer.End();
        return null;
    }

    public object RunJS(JsEnv env, int count, out double duration)
    {
        duration = env.Eval<double>(string.Format(
@"(function() {{
    function fibonacci(level) {{
        if (level == 0) return 0;
        if (level == 1) return 1;
        return fibonacci(level - 1) + fibonacci(level - 2);
    }}

    const start = Date.now();
    let sum = 0;
    for (let i = 0; i < {0}; i++) {{
        sum += fibonacci(8)
    }}
    return Date.now() - start;
}})()", count));
        return null;
    }
    public object RunLua(LuaEnv env, int count, out double duration)
    {
        duration = 1000 * (double)env.DoString(string.Format(
@"
        local function fibonacci(n)
            if n == 0 then 
                return 0
            end
            if n == 1 then 
                return 1
            end
            return fibonacci(n - 1) + fibonacci(n - 2)
        end

        start = os.clock()
        local sum = 0;
        for i = 1,{0} 
        do
            sum = sum + fibonacci(8)
        end
        return os.clock() - start;
", count))[0];
        return null;
    }
}
