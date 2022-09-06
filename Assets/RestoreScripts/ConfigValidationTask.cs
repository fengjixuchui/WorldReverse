/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ConfigValidationTask : ThreadTask<ConfigValidationData> // TypeDefIndex: 26588
{
    // Fields
    private const string _taskName = "ConfigValidation"; // Metadata: 0x00B0C5BC
    private Queue<ConfigHashValidationPattern> _hashValidatingPatterns; // 0x48
    private Queue<ConfigHashValidationPattern> _hashComputedPatterns; // 0x50

    // Properties
    public override string taskName { /* [XID] */ /* 0x000000018961A360-0x000000018961A380 */ get => default; } // 0x00000001818FC9A0-0x00000001818FCA50 

    // Constructors
    public ConfigValidationTask() { } // 0x00000001818FC8E0-0x00000001818FC9A0

    // Methods
    // [XID] // 0x00000001896218F0-0x0000000189621910
    public override void Collect() { } // 0x00000001818FBE20-0x00000001818FBEC0
                                       // [XID] // 0x00000001896291C0-0x00000001896291E0
    public void ClearOnLevelDestroy()
    {
        var hash = _taskData.QueueToValidateHash;
        while (hash.Empty())
        {
            var h = hash.Dequeue();
            if (h != null)
            {
                ConfigHashValidationPattern.Release(h);
            }
        }
    } // 0x00000001818FBCF0-0x00000001818FBE20
      // [XID] // 0x0000000189630B20-0x0000000189630B40
    private void DispatchHashValidations() { } // 0x00000001818FBFF0-0x00000001818FC270
                                               // [XID] // 0x0000000189638640-0x0000000189638660
    public override void Execute() { } // 0x00000001818FC270-0x00000001818FC390
                                       // [XID] // 0x000000018963FA00-0x000000018963FA20
    public override void Flush() { } // 0x00000001818FC390-0x00000001818FC690
                                     // [XID] // 0x0000000189647220-0x0000000189647240
    protected override void OnDestroy() { } // 0x00000001818FC800-0x00000001818FC8E0
                                            // [XID] // 0x000000018964E8F0-0x000000018964E910
    public ConfigHashValidationPattern CreateValidationPattern(ConfigHashGetter hashGetter, Action<uint, int, object, uint> onHashCalculated) => default; // 0x00000001818FC6F0-0x00000001818FC800
}

