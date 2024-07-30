//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace Conf
{
public sealed partial class ItemInfo :  Bright.Config.BeanBase 
{
    public ItemInfo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Type = _buf.ReadInt();
        Stack = _buf.ReadInt();
        Quality = _buf.ReadInt();
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        Icon = _buf.ReadString();
        Link = _buf.ReadInt();
        PostInit();
    }

    public static ItemInfo DeserializeItemInfo(ByteBuf _buf)
    {
        return new Conf.ItemInfo(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 类型
    /// </summary>
    public int Type { get; private set; }
    /// <summary>
    /// 堆叠
    /// </summary>
    public int Stack { get; private set; }
    /// <summary>
    /// 品质
    /// </summary>
    public int Quality { get; private set; }
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 描述
    /// </summary>
    public string Desc { get; private set; }
    /// <summary>
    /// 图标
    /// </summary>
    public string Icon { get; private set; }
    /// <summary>
    /// 跳转 ID
    /// </summary>
    public int Link { get; private set; }

    public const int __ID__ = 2765291;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Type:" + Type + ","
        + "Stack:" + Stack + ","
        + "Quality:" + Quality + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Icon:" + Icon + ","
        + "Link:" + Link + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}