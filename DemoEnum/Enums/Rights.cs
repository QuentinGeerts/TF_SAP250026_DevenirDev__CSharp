namespace DemoEnum.Enums;

[Flags]
public enum Rights
{
    None = 0,       // 0000 0001
    Read = 1,       // 0000 0010
    Write = 2,      // 0000 0100
    Execute = 4     // 0000 1000
}
