
# 软件版本
| Name            | Value             |
| :----           | :----:            |
| Unity           | 2020.3.35f1c1               |
| puerts          | 16               |
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
| Date            | 2022-10-18 15:58:45               |
# 数据对照
* ParameterCompare | 	`无参数 vs 有参数`

| File      | Method    | Static    | Target    | Call      | csharp(ms)| puerts(ms)| xLua(ms)  | csharpResult  | puertsResult  | xLuaResult    |
| :----:    | :----     | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:        | :----:        | :----:        |
| [:page_facing_up:](//Assets/CScripts/Examples/Example1.cs)       | void Payload();       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 22.0       | 33.4       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example3.cs)       | void Payload(int);       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 54.2       | 39.7       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example4.cs)       | void Payload(int, int, float);       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 113.0       | 57.0       | `null`           | `null`           | `null`          |
* Static vs Instance | 	`静态函数 vs 实例函数`

| File      | Method    | Static    | Target    | Call      | csharp(ms)| puerts(ms)| xLua(ms)  | csharpResult  | puertsResult  | xLuaResult    |
| :----:    | :----     | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:        | :----:        | :----:        |
| [:page_facing_up:](//Assets/CScripts/Examples/Example1.cs)       | void Payload();       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 22.0       | 33.4       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example2.cs)       | void Payload();       | ×       | ScriptCallCSharp       | 1000000       | 0.0       | 38.6       | 94.3       | `null`           | `null`           | `null`          |
* xyz vs Vector3 | 	`xyz传参 vs Vector3传参`

| File      | Method    | Static    | Target    | Call      | csharp(ms)| puerts(ms)| xLua(ms)  | csharpResult  | puertsResult  | xLuaResult    |
| :----:    | :----     | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:        | :----:        | :----:        |
| [:page_facing_up:](//Assets/CScripts/Examples/Example8.cs)       | Quaternion Payload(Transform, float, float, float);       | √       | ScriptCallCSharp       | 1000000       | 150.7       | 596.8       | 357.2       | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example9.cs)       | Quaternion Payload(Transform, Vector3);       | √       | ScriptCallCSharp       | 1000000       | 117.9       | 778.8       | 320.5       | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)          |
# 所有数据
| File      | Method    | Static    | Target    | Call      | csharp(ms)| puerts(ms)| xLua(ms)  | csharpResult  | puertsResult  | xLuaResult    |
| :----:    | :----     | :----:    | :----:    | :----:    | :----:    | :----:    | :----:    | :----:        | :----:        | :----:        |
| [:page_facing_up:](//Assets/CScripts/Examples/Example1.cs)       | void Payload();       | √       | ScriptCallCSharp       | 10000       | 0.0       | 2.0       | 1.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example1.cs)       | void Payload();       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 22.0       | 33.4       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example2.cs)       | void Payload();       | ×       | ScriptCallCSharp       | 10000       | 0.0       | 2.1       | 0.9       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example2.cs)       | void Payload();       | ×       | ScriptCallCSharp       | 1000000       | 0.0       | 38.6       | 94.3       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example3.cs)       | void Payload(int);       | √       | ScriptCallCSharp       | 10000       | 0.0       | 1.8       | 0.9       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example3.cs)       | void Payload(int);       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 54.2       | 39.7       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example4.cs)       | void Payload(int, int, float);       | √       | ScriptCallCSharp       | 10000       | 0.0       | 2.0       | 0.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example4.cs)       | void Payload(int, int, float);       | √       | ScriptCallCSharp       | 1000000       | 0.0       | 113.0       | 57.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example5.cs)       | float Payload(int, int, float);       | √       | ScriptCallCSharp       | 10000       | 0.0       | 9.0       | 1.0       | 1.500183E+08           | 1.50015E+08           | 150015000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example5.cs)       | float Payload(int, int, float);       | √       | ScriptCallCSharp       | 1000000       | 1.0       | 142.4       | 65.0       | 1.500443E+12           | 1.500001E+12           | 1500001500000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example6.cs)       | float Payload();       | √       | ScriptCallCSharp       | 10000       | 0.0       | 1.6       | 0.9       | 60000           | 60000           | 60000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example6.cs)       | float Payload();       | √       | ScriptCallCSharp       | 1000000       | 1.0       | 38.9       | 41.1       | 6000000           | 6000000           | 6000000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example7.cs)       | Quaternion Payload(Transform);       | √       | ScriptCallCSharp       | 10000       | 1.0       | 9.0       | 4.0       | (-0.1, -0.1, -0.1, 1.0)           | (-0.1, -0.1, -0.1, 1.0)           | (-0.1, -0.1, -0.1, 1.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example7.cs)       | Quaternion Payload(Transform);       | √       | ScriptCallCSharp       | 1000000       | 117.0       | 488.0       | 281.0       | (-0.3, -0.3, -0.3, -0.9)           | (-0.3, -0.3, -0.3, -0.9)           | (-0.3, -0.3, -0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example8.cs)       | Quaternion Payload(Transform, float, float, float);       | √       | ScriptCallCSharp       | 10000       | 2.0       | 11.1       | 4.0       | (0.4, 0.5, 0.7, 0.0)           | (0.4, 0.5, 0.7, 0.0)           | (0.4, 0.5, 0.7, 0.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example8.cs)       | Quaternion Payload(Transform, float, float, float);       | √       | ScriptCallCSharp       | 1000000       | 150.7       | 596.8       | 357.2       | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example9.cs)       | Quaternion Payload(Transform, Vector3);       | √       | ScriptCallCSharp       | 10000       | 1.6       | 10.0       | 4.0       | (-0.3, -0.5, -0.8, 0.1)           | (-0.3, -0.5, -0.8, 0.1)           | (-0.3, -0.5, -0.8, 0.1)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example9.cs)       | Quaternion Payload(Transform, Vector3);       | √       | ScriptCallCSharp       | 1000000       | 117.9       | 778.8       | 320.5       | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example101.cs)       | payload(): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 3.0       | 0.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example101.cs)       | payload(): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 264.5       | 56.2       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example103.cs)       | payload(number): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 6.0       | 2.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example103.cs)       | payload(number): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 556.1       | 59.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example104.cs)       | payload(number,number,number): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 11.0       | 1.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example104.cs)       | payload(number,number,number): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 642.9       | 65.0       | `null`           | `null`           | `null`          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example105.cs)       | payload(number,number,number): number;       | √       | CSharpCallScript       | 10000       | `fail`       | 9.0       | 1.0       | `null`           | 1.500183E+08           | 1.500183E+08          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example105.cs)       | payload(number,number,number): number;       | √       | CSharpCallScript       | 1000000       | `fail`       | 805.9       | 80.8       | `null`           | 1.500443E+12           | 1.500443E+12          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example106.cs)       | payload(): number;       | √       | CSharpCallScript       | 10000       | `fail`       | 4.9       | 1.0       | `null`           | 60000           | 60000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example106.cs)       | payload(): number;       | √       | CSharpCallScript       | 1000000       | `fail`       | 450.6       | 67.5       | `null`           | 6000000           | 6000000          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example107.cs)       | payload(Transform): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 31.2       | 20.0       | `null`           | (-0.1, -0.1, -0.1, 1.0)           | (-0.1, -0.1, -0.1, 1.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example107.cs)       | payload(Transform): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 2404.9       | 1832.1       | `null`           | (-0.3, -0.3, -0.3, -0.9)           | (-0.3, -0.3, -0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example108.cs)       | payload(Transform,float,float,float): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 35.5       | 19.0       | `null`           | (0.4, 0.5, 0.7, 0.0)           | (0.4, 0.5, 0.7, 0.0)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example108.cs)       | payload(Transform,float,float,float): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 2609.6       | 1871.5       | `null`           | (0.2, 0.2, 0.3, -0.9)           | (0.2, 0.2, 0.3, -0.9)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example109.cs)       | payload(Transform,Vector3): void;       | √       | CSharpCallScript       | 10000       | `fail`       | 43.4       | 31.0       | `null`           | (-0.3, -0.5, -0.8, 0.1)           | (-0.3, -0.5, -0.8, 0.1)          |
| [:page_facing_up:](//Assets/CScripts/Examples/Example109.cs)       | payload(Transform,Vector3): void;       | √       | CSharpCallScript       | 1000000       | `fail`       | 4251.6       | 3059.0       | `null`           | (0.1, 0.1, 0.2, 1.0)           | (0.1, 0.1, 0.2, 1.0)          |