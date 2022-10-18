
# 软件版本
| Name            | Value             |
| :----           | :----:            |
| Unity           | 2020.3.35f1c1               |
| puerts          | 18               |
| xLua            | 105               |
# 系统环境
| Name            | Value             |
| :----           | :----:            |
| System          | Windows 10  (10.0.19043) 64bit               |
| Memory          | 16311MB             |
| CPU             | Intel(R) Core(TM) i7-7700 CPU @ 3.60GHz               |
| CPU-Core        | 8               |
| CPU-Frequency   | 3.6GHz            |
| Editor          | False               |
| Date            | 2022-10-18 15:39:33               |
# 数据对照
* ParameterCompare | 	`无参数 vs 有参数`

| File      | Method    | Static    | Target    | Call      | csharp(ms)| puerts(ms)| xLua(ms)  | csharpResult  | puertsResult  | xLuaResult    |
| :----:    | :----     | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:        | :----:        | :----:        |
| [:page_facing_up:](//Assets/CScripts/Examples/Example1.cs)       | void Payload();       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 22.3       | 34.1       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example3.cs)       | void Payload(int);       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 73.4       | 39.2       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example4.cs)       | void Payload(int, int, float);       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 160.0       | 63.0       | `null`           | `null`           | `null`          |
* Static vs Instance | 	`静态函数 vs 实例函数`

| File      | Method    | Static    | Target    | Call      | csharp(ms)| puerts(ms)| xLua(ms)  | csharpResult  | puertsResult  | xLuaResult    |
| :----:    | :----     | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:        | :----:        | :----:        |
| [:page_facing_up:](//Assets/CScripts/Examples/Example1.cs)       | void Payload();       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 22.3       | 34.1       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example2.cs)       | void Payload();       | ×       | ScriptCallCSharp       | 1000000       | 0.9       | 41.0       | 96.2       | `null`           | `null`           | `null`          |
* xyz vs Vector3 | 	`xyz传参 vs Vector3传参`

| File      | Method    | Static    | Target    | Call      | csharp(ms)| puerts(ms)| xLua(ms)  | csharpResult  | puertsResult  | xLuaResult    |
| :----:    | :----     | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:        | :----:        | :----:        |
| [:page_facing_up:](//Assets/CScripts/Examples/Example8.cs)       | Quaternion Payload(Transform, float, float, float);       | √       | ScriptCallCSharp       | 1000000       | 165.1       | 474.0       | 333.0       | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example9.cs)       | Quaternion Payload(Transform, Vector3);       | √       | ScriptCallCSharp       | 1000000       | 116.6       | 474.3       | 312.0       | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)          |
# 所有数据
| File      | Method    | Static    | Target    | Call      | csharp(ms)| puerts(ms)| xLua(ms)  | csharpResult  | puertsResult  | xLuaResult    |
| :----:    | :----     | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:        | :----:        | :----:        |
| [:page_facing_up:](//Assets/CScripts/Examples/Example1.cs)       | void Payload();       | √       | ScriptCallCSharp       | 10000       | 0.0       | 2.0       | 1.3       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example1.cs)       | void Payload();       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 22.3       | 34.1       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example2.cs)       | void Payload();       | ×       | ScriptCallCSharp       | 10000       | 0.0       | 2.4       | 1.6       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example2.cs)       | void Payload();       | ×       | ScriptCallCSharp       | 1000000       | 0.9       | 41.0       | 96.2       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example3.cs)       | void Payload(int);       | √       | ScriptCallCSharp       | 10000       | 0.0       | 2.6       | 1.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example3.cs)       | void Payload(int);       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 73.4       | 39.2       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example4.cs)       | void Payload(int, int, float);       | √       | ScriptCallCSharp       | 10000       | 0.0       | 3.0       | 1.9       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example4.cs)       | void Payload(int, int, float);       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 160.0       | 63.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example5.cs)       | float Payload(int, int, float);       | √       | ScriptCallCSharp       | 10000       | 0.0       | 4.0       | 1.0       | 1.500183E+08           | 1.50015E+08           | 150015000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example5.cs)       | float Payload(int, int, float);       | √       | ScriptCallCSharp       | 1000000       | 1.0       | 197.0       | 67.0       | 1.500443E+12           | 1.500001E+12           | 1500001500000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example6.cs)       | float Payload();       | √       | ScriptCallCSharp       | 10000       | 0.0       | 2.0       | 1.0       | 60000           | 60000           | 60000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example6.cs)       | float Payload();       | √       | ScriptCallCSharp       | 1000000       | 2.1       | 52.1       | 43.0       | 6000000           | 6000000           | 6000000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example7.cs)       | Quaternion Payload(Transform);       | √       | ScriptCallCSharp       | 10000       | 1.0       | 6.0       | 4.0       | (-0.1, -0.1, -0.1, 1.0)           | (-0.1, -0.1, -0.1, 1.0)           | (-0.1, -0.1, -0.1, 1.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example7.cs)       | Quaternion Payload(Transform);       | √       | ScriptCallCSharp       | 1000000       | 122.8       | 325.6       | 261.6       | (-0.3, -0.3, -0.3, -0.9)           | (-0.3, -0.3, -0.3, -0.9)           | (-0.3, -0.3, -0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example8.cs)       | Quaternion Payload(Transform, float, float, float);       | √       | ScriptCallCSharp       | 10000       | 1.0       | 7.0       | 3.0       | (0.4, 0.5, 0.7, 0.0)           | (0.4, 0.5, 0.7, 0.0)           | (0.4, 0.5, 0.7, 0.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example8.cs)       | Quaternion Payload(Transform, float, float, float);       | √       | ScriptCallCSharp       | 1000000       | 165.1       | 474.0       | 333.0       | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example9.cs)       | Quaternion Payload(Transform, Vector3);       | √       | ScriptCallCSharp       | 10000       | 1.0       | 8.0       | 4.1       | (-0.3, -0.5, -0.8, 0.1)           | (-0.3, -0.5, -0.8, 0.1)           | (-0.3, -0.5, -0.8, 0.1)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example9.cs)       | Quaternion Payload(Transform, Vector3);       | √       | ScriptCallCSharp       | 1000000       | 116.6       | 474.3       | 312.0       | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example101.cs)       | payload(): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 3.2       | 1.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example101.cs)       | payload(): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 298.5       | 57.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example103.cs)       | payload(number): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 7.8       | 1.1       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example103.cs)       | payload(number): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 605.5       | 58.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example104.cs)       | payload(number,number,number): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 13.2       | 1.1       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example104.cs)       | payload(number,number,number): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 674.0       | 64.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example105.cs)       | payload(number,number,number): number;       | √       | CSharpCallScript       | 10000       | `fail`       | 14.0       | 1.0       | `null`           | 1.500183E+08           | 1.500183E+08          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example105.cs)       | payload(number,number,number): number;       | √       | CSharpCallScript       | 1000000       | `fail`       | 864.1       | 79.2       | `null`           | 1.500443E+12           | 1.500443E+12          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example106.cs)       | payload(): number;       | √       | CSharpCallScript       | 10000       | `fail`       | 5.0       | 0.9       | `null`           | 60000           | 60000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example106.cs)       | payload(): number;       | √       | CSharpCallScript       | 1000000       | `fail`       | 516.4       | 67.0       | `null`           | 6000000           | 6000000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example107.cs)       | payload(Transform): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 30.8       | 21.0       | `null`           | (-0.1, -0.1, -0.1, 1.0)           | (-0.1, -0.1, -0.1, 1.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example107.cs)       | payload(Transform): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 2663.1       | 1904.9       | `null`           | (-0.3, -0.3, -0.3, -0.9)           | (-0.3, -0.3, -0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example108.cs)       | payload(Transform,float,float,float): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 31.0       | 19.0       | `null`           | (0.4, 0.5, 0.7, 0.0)           | (0.4, 0.5, 0.7, 0.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example108.cs)       | payload(Transform,float,float,float): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 2882.1       | 1989.1       | `null`           | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example109.cs)       | payload(Transform,Vector3): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 52.1       | 36.4       | `null`           | (-0.3, -0.5, -0.8, 0.1)           | (-0.3, -0.5, -0.8, 0.1)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example109.cs)       | payload(Transform,Vector3): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 4644.4       | 3124.3       | `null`           | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)          |