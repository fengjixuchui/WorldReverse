/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigUIGlobal : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19107
{
    // Fields
    // [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
    private Dictionary<InputActionType, ConfigBaseInputAction> _inputActions; // 0x10
                                                                              // [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
    private Dictionary<InputEventType, ConfigBaseInputEvent> _inputEvents; // 0x18
    private Dictionary<string, InputActionEvent[]> _actionGroups; // 0x20
                                                                  // [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
    private Dictionary<string, ConfigBaseContext> _inputModes; // 0x28
    private Point2D _joypadChangeViewScale; // 0x30
    private SimpleSafeFloat joypadLongPressDurationRawNum; // 0x38
    private SimpleSafeFloat[] _joypadSenseScales; // 0x40
    private SimpleSafeFloat[] _joypadFocusSenseScales; // 0x48
    private SimpleSafeFloat[] _mouseSenseScales; // 0x50
    private SimpleSafeFloat[] _mouseFocusSenseScales; // 0x58
    private SimpleSafeFloat[] _touchpadSenseScales; // 0x60
    private SimpleSafeFloat[] _touchpadFocusSenseScales; // 0x68
    private SimpleSafeFloat[] _touchpadFocusAccelerationScales; // 0x70
                                                                // [PooledField] // 0x0000000189951E30-0x0000000189951E50
    private TouchpadFocusAccelerationSigmoidPara _touchpadFocusAccelerationPara; // 0x78
                                                                                 // [PooledField] // 0x0000000189951E30-0x0000000189951E50
    private ConfigUIPhotograph _configUIPhotograph; // 0x80

    // Properties
    public Dictionary<InputActionType, ConfigBaseInputAction> inputActions { /* [XID] */ /* 0x0000000189911160-0x0000000189911180 */ get => default; /* [XID] */ /* 0x0000000189918DA0-0x0000000189918DC0 */ private set { } } // 0x000000018285E170-0x000000018285E210 0x000000018285DF30-0x000000018285DFE0
    public Dictionary<InputEventType, ConfigBaseInputEvent> inputEvents { /* [XID] */ /* 0x0000000189920370-0x0000000189920390 */ get => default; /* [XID] */ /* 0x0000000189927C10-0x0000000189927C30 */ private set { } } // 0x000000018285D840-0x000000018285D8E0 0x000000018285D0D0-0x000000018285D180
    public Dictionary<string, InputActionEvent[]> actionGroups { /* [XID] */ /* 0x0000000189A80D50-0x0000000189A80D70 */ get => default; /* [XID] */ /* 0x00000001899367B0-0x00000001899367D0 */ private set { } } // 0x000000018285D640-0x000000018285D6E0 0x000000018285A900-0x000000018285A9B0
    public Dictionary<string, ConfigBaseContext> inputModes { /* [XID] */ /* 0x0000000189823D40-0x0000000189823D60 */ get => default; /* [XID] */ /* 0x00000001899459A0-0x00000001899459C0 */ private set { } } // 0x000000018285A860-0x000000018285A900 0x000000018285F1B0-0x000000018285F260
    public Point2D joypadChangeViewScale { /* [XID] */ /* 0x0000000189702510-0x0000000189702530 */ get => default; /* [XID] */ /* 0x0000000189954600-0x0000000189954620 */ private set { } } // 0x000000018285BAD0-0x000000018285BB70 0x000000018285C120-0x000000018285C1D0
    public float joypadLongPressDuration { /* [XID] */ /* 0x000000018995BE80-0x000000018995BEA0 */ get => default; /* [XID] */ /* 0x0000000189963940-0x0000000189963960 */ private set { } } // 0x000000018285E090-0x000000018285E170 0x000000018285BF00-0x000000018285BFE0
    public SimpleSafeFloat[] joypadSenseScales { /* [XID] */ /* 0x000000018996AE90-0x000000018996AEB0 */ get => default; /* [XID] */ /* 0x00000001899729B0-0x00000001899729D0 */ private set { } } // 0x000000018285D500-0x000000018285D5A0 0x000000018285C280-0x000000018285C330
    public SimpleSafeFloat[] joypadFocusSenseScales { /* [XID] */ /* 0x000000018997A190-0x000000018997A1B0 */ get => default; /* [XID] */ /* 0x0000000189981960-0x0000000189981980 */ private set { } } // 0x000000018285D030-0x000000018285D0D0 0x000000018285DE80-0x000000018285DF30
    public SimpleSafeFloat[] mouseSenseScales { /* [XID] */ /* 0x0000000189991850-0x0000000189991870 */ get => default; /* [XID] */ /* 0x0000000189990A30-0x0000000189990A50 */ private set { } } // 0x000000018285D5A0-0x000000018285D640 0x000000018285C1D0-0x000000018285C280
    public SimpleSafeFloat[] mouseFocusSenseScales { /* [XID] */ /* 0x0000000189AA7A30-0x0000000189AA7A50 */ get => default; /* [XID] */ /* 0x000000018999FD50-0x000000018999FD70 */ private set { } } // 0x000000018285CF90-0x000000018285D030 0x000000018285F260-0x000000018285F310
    public SimpleSafeFloat[] touchpadSenseScales { /* [XID] */ /* 0x00000001899A7A40-0x00000001899A7A60 */ get => default; /* [XID] */ /* 0x00000001899AF230-0x00000001899AF250 */ private set { } } // 0x000000018285C080-0x000000018285C120 0x000000018285D790-0x000000018285D840
    public SimpleSafeFloat[] touchpadFocusSenseScales { /* [XID] */ /* 0x00000001899B6510-0x00000001899B6530 */ get => default; /* [XID] */ /* 0x00000001899BE110-0x00000001899BE130 */ private set { } } // 0x000000018285F310-0x000000018285F3B0 0x000000018285BB70-0x000000018285BC20
    public SimpleSafeFloat[] touchpadFocusAccelerationScales { /* [XID] */ /* 0x00000001899C5910-0x00000001899C5930 */ get => default; /* [XID] */ /* 0x00000001899CCF50-0x00000001899CCF70 */ private set { } } // 0x000000018285BFE0-0x000000018285C080 0x000000018285DFE0-0x000000018285E090
    public TouchpadFocusAccelerationSigmoidPara touchpadFocusAccelerationPara { /* [XID] */ /* 0x00000001899D44F0-0x00000001899D4510 */ get => default; /* [XID] */ /* 0x00000001899DBC30-0x00000001899DBC50 */ private set { } } // 0x000000018285CEF0-0x000000018285CF90 0x000000018285D6E0-0x000000018285D790
    public ConfigUIPhotograph configUIPhotograph { /* [XID] */ /* 0x00000001899E3630-0x00000001899E3650 */ get => default; /* [XID] */ /* 0x00000001899EA9C0-0x00000001899EA9E0 */ private set { } } // 0x000000018285F3B0-0x000000018285F460 0x000000018285DDD0-0x000000018285DE80

    // Constructors
    public ConfigUIGlobal() { } // 0x000000018285F500-0x000000018285F560

    // Methods
    // [XID] // 0x00000001899F2520-0x00000001899F2540
    public virtual void ObjectContentHashOnto(ref int hash_code) { } // 0x000000018285EDE0-0x000000018285F070
                                                                     // [XID] // 0x00000001899F9AF0-0x00000001899F9B10
    public void InitEmpty() { } // 0x000000018285D8E0-0x000000018285DAD0
    [BlackList] // 0x0000000189A00EF0-0x0000000189A00F30
                // [XID] // 0x0000000189A00EF0-0x0000000189A00F30
    public bool FromJson(JSONNode node)
    {
        if (node == null)
        {
            SuperDebug.LogError("node is null");
            return false;
        }
        else
        {
            return InternalFromJson(node);
        }
    }// 0x000000018285D180-0x000000018285D500
     // [XID] // 0x00000001896785D0-0x00000001896785F0
    private bool InternalFromJson(JSONNode node)
    {
        var inputAction = node["inputActions"];
        if (inputAction == null)
        {
            JsonTool.GetEmptyValue(out _inputActions);
        }
        else
        {
            if (!JsonTool.DictFromJson(inputAction, out _inputActions))
            {
                SuperDebug.LogError("FromJson for: inputActions fails!" + inputAction.ToString());
                return false;
            }
        }
        var inputEvent = node["inputEvents"];
        if (inputEvent == null)
        {
            JsonTool.GetEmptyValue(out _inputEvents);
        }
        else
        {
            if (!JsonTool.DictFromJson(inputEvent, out _inputEvents))
            {
                SuperDebug.LogError("FromJson for: inputEvents fails!" + inputEvent.ToString());
                return false;
            }
        }
        var actionGroups = node["actionGroups"];
        if (actionGroups == null)
        {
            JsonTool.GetEmptyValue(out _actionGroups);
        }
        else
        {
            if (!JsonTool.DictFromJson(actionGroups, out _actionGroups))
            {
                SuperDebug.LogError("FromJson for: actionGroups fails!" + actionGroups.ToString());
                return false;
            }
        }
        var inputModes = node["inputModes"];
        if (inputModes == null)
        {
            JsonTool.GetEmptyValue(out _inputModes);
        }
        else
        {
            if (!JsonTool.DictFromJson(inputModes, out _inputModes))
            {
                SuperDebug.LogError("FromJson for: inputModes fails!" + inputModes.ToString());
                return false;
            }
        }
        var joypadChangeViewScale = node["joypadChangeViewScale"];
        if (joypadChangeViewScale == null)
        {
            JsonTool.GetEmptyValue(out _joypadChangeViewScale);
        }
        else
        {
            _joypadChangeViewScale = new Point2D();
            if (!_joypadChangeViewScale.FromJson(joypadChangeViewScale))
            {
                SuperDebug.LogError("FromJson for: joypadChangeViewScale fails!" + joypadChangeViewScale.ToString());
                return false;
            }
        }
        float num;
        var joypadLongPressDuration = node["joypadLongPressDuration"];
        if (joypadLongPressDuration == null)
        {
            num = 0f;
        }
        else
        {
            if (!JsonTool.FromJson(joypadLongPressDuration, out num))
            {
                SuperDebug.LogError("FromJson for: joypadLongPressDuration fails!" + num.ToString());
                return false;
            }
        }
        joypadLongPressDurationRawNum = num;
        var joypadSenseScales = node["joypadSenseScales"];
        if (joypadSenseScales == null)
        {
            JsonTool.GetEmptyValue(out _joypadSenseScales);
        }
        else
        {
            if (!JsonTool.ArrayFromJson(joypadSenseScales, out _joypadSenseScales))
            {
                SuperDebug.LogError("FromJson for: joypadSenseScales fails!" + joypadSenseScales.ToString());
                return false;
            }
        }
        var joypadFocusSenseScales = node["joypadFocusSenseScales"];
        if (joypadFocusSenseScales == null)
        {
            JsonTool.GetEmptyValue(out _joypadFocusSenseScales);
        }
        else
        {
            if (!JsonTool.ArrayFromJson(joypadFocusSenseScales, out _joypadFocusSenseScales))
            {
                SuperDebug.LogError("FromJson for: joypadFocusSenseScales fails!" + joypadFocusSenseScales.ToString());
                return false;
            }
        }
        var mouseSenseScales = node["mouseSenseScales"];
        if (mouseSenseScales == null)
        {
            JsonTool.GetEmptyValue(out _mouseSenseScales);
        }
        else
        {
            if (!JsonTool.ArrayFromJson(mouseSenseScales, out _mouseSenseScales))
            {
                SuperDebug.LogError("FromJson for: mouseSenseScales fails!" + mouseSenseScales.ToString());
                return false;
            }
        }
        var mouseFocusSenseScales = node["mouseFocusSenseScales"];
        if (mouseFocusSenseScales == null)
        {
            JsonTool.GetEmptyValue(out _mouseFocusSenseScales);
        }
        else
        {
            if (!JsonTool.ArrayFromJson(mouseFocusSenseScales, out _mouseFocusSenseScales))
            {
                SuperDebug.LogError("FromJson for: mouseFocusSenseScales fails!" + mouseFocusSenseScales.ToString());
                return false;
            }
        }
        var touchpadSenseScales = node["touchpadSenseScales"];
        if (touchpadSenseScales == null)
        {
            JsonTool.GetEmptyValue(out _touchpadSenseScales);
        }
        else
        {
            if (!JsonTool.ArrayFromJson(touchpadSenseScales, out _touchpadSenseScales))
            {
                SuperDebug.LogError("FromJson for: touchpadSenseScales fails!" + touchpadSenseScales.ToString());
                return false;
            }
        }
        var touchpadFocusSenseScales = node["touchpadFocusSenseScales"];
        if (touchpadFocusSenseScales == null)
        {
            JsonTool.GetEmptyValue(out _touchpadFocusSenseScales);
        }
        else
        {
            if (!JsonTool.ArrayFromJson(touchpadFocusSenseScales, out _touchpadFocusSenseScales))
            {
                SuperDebug.LogError("FromJson for: touchpadSenseScales fails!" + touchpadFocusSenseScales.ToString());
                return false;
            }
        }
        var touchpadFocusAccelerationScales = node["touchpadFocusAccelerationScales"];
        if (touchpadFocusAccelerationScales == null)
        {
            JsonTool.GetEmptyValue(out _touchpadFocusAccelerationScales);
        }
        else
        {
            if (!JsonTool.ArrayFromJson(touchpadFocusAccelerationScales, out _touchpadFocusAccelerationScales))
            {
                SuperDebug.LogError("FromJson for: touchpadSenseScales fails!" + touchpadFocusAccelerationScales.ToString());
                return false;
            }
        }
        var touchpadFocusAccelerationPara = node["touchpadFocusAccelerationPara"];
        if (touchpadFocusAccelerationPara == null)
        {
            JsonTool.GetEmptyValue(out _touchpadFocusAccelerationPara);
        }
        else
        {
            _touchpadFocusAccelerationPara = new TouchpadFocusAccelerationSigmoidPara();
            if (!_touchpadFocusAccelerationPara.FromJson(touchpadFocusAccelerationPara))
            {
                SuperDebug.LogError("FromJson for: touchpadFocusAccelerationPara fails!" + touchpadFocusAccelerationPara.ToString());
                return false;
            }
        }
        var configUIPhotograph = node["configUIPhotograph"];
        if (configUIPhotograph == null)
        {
            JsonTool.GetEmptyValue(out _configUIPhotograph);
        }
        else
        {
            _configUIPhotograph = new ConfigUIPhotograph();
            if (!_configUIPhotograph.FromJson(configUIPhotograph))
            {
                SuperDebug.LogError("FromJson for: touchpadFocusAccelerationPara fails!" + configUIPhotograph.ToString());
                return false;
            }
        }
        return true;
    }// 0x000000018285A9B0-0x000000018285B800
     // [XID] // 0x00000001899C1F50-0x00000001899C1F70
    public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC201 */, bool useObjectPool = false /* Metadata: 0x00AFC205 */) => default; // 0x000000018285DAD0-0x000000018285DDD0
                                                                                                                                                                  // [XID] // 0x0000000189A1A2F0-0x0000000189A1A310
    private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC206 */, bool useObjectPool = false /* Metadata: 0x00AFC20A */) => default; // 0x000000018285C330-0x000000018285CEF0
    [BlackList] // 0x0000000189A21870-0x0000000189A218B0
                // [XID] // 0x0000000189A21870-0x0000000189A218B0
    public bool ToBinary(ByteArray byteArray) => default; // 0x000000018285B800-0x000000018285BAD0
                                                          // [XID] // 0x0000000189A2BCB0-0x0000000189A2BCD0
    private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018285E210-0x000000018285EDE0
    [BlackList] // 0x0000000189A332E0-0x0000000189A33320
                // [XID] // 0x0000000189A332E0-0x0000000189A33320
    public virtual void AutoAllocTypeFields() { } // 0x000000018285BC20-0x000000018285BCC0
    [BlackList] // 0x0000000189A3DD10-0x0000000189A3DD50
                // [XID] // 0x0000000189A3DD10-0x0000000189A3DD50
    public virtual void AutoRecycleTypeFields() { } // 0x000000018285BCC0-0x000000018285BF00
    [BlackList] // 0x0000000189A48450-0x0000000189A48490
                // [XID] // 0x0000000189A48450-0x0000000189A48490
    public virtual void ReturnToObjectPool() { } // 0x000000018285F460-0x000000018285F500
    [BlackList] // 0x0000000189A52A20-0x0000000189A52A60
                // [XID] // 0x0000000189A52A20-0x0000000189A52A60
    public virtual void OnPoolAllocated() { } // 0x000000018285F110-0x000000018285F1B0
    [BlackList] // 0x0000000189A5D540-0x0000000189A5D580
                // [XID] // 0x0000000189A5D540-0x0000000189A5D580
    public virtual void OnBeforePoolRecycled() { } // 0x000000018285F070-0x000000018285F110
}

