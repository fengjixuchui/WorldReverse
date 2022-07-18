/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface ITickBalanceObject // TypeDefIndex: 21286
{
    // Properties
    bool bIgnoreIntervalTick { get; set; }
    int tickInterval { get; }
    int tickBalanceRemainder { get; }
    int requestTickInterval { get; }
    bool canBeTickBalanced { get; }
    int greaterToDisableInterval { get; set; }
    bool isTickable { get; }
    float balanceTickDeltaTime { get; }
}

