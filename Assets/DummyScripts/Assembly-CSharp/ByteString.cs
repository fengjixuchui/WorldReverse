/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ByteString : IEnumerable<byte>, IEquatable<ByteString> // TypeDefIndex: 26296
{
	// Fields
	private static readonly ByteString empty; // 0x00
	private bool _isReadOnly; // 0x10
	private byte[] bytes; // 0x18

	// Properties
	public static ByteString Empty { /* [XID] */ /* 0x00000001897708D0-0x00000001897708F0 */ get => default; } // 0x0000000183D00C00-0x0000000183D00CD0 
	public int Length { /* [XID] */ /* 0x000000018974B950-0x000000018974B970 */ get => default; } // 0x0000000183D011A0-0x0000000183D01250 
	public bool IsEmpty { /* [XID] */ /* 0x000000018979CFC0-0x000000018979CFE0 */ get => default; } // 0x0000000183CFFC10-0x0000000183CFFCC0 
	public byte this[int index] { /* [XID] */ /* 0x00000001897F1BB0-0x00000001897F1BD0 */ get => default; } // 0x0000000183D013B0-0x0000000183D01490 

	// Nested types
	internal static class Unsafe // TypeDefIndex: 26297
	{
		// Methods
		// [XID] // 0x000000018985F090-0x000000018985F0B0
		internal static ByteString FromBytes(byte[] bytes) => default; // 0x0000000183D16440-0x0000000183D16510
		// [XID] // 0x0000000189866880-0x00000001898668A0
		internal static byte[] GetBuffer(ByteString bytes) => default; // 0x0000000183D16390-0x0000000183D16440
	}

	// Constructors
	public ByteString() {} // 0x0000000183D01940-0x0000000183D019A0
	public ByteString(byte[] bytes, bool isReadOnly = false /* Metadata: 0x00B0BDAD */) {} // 0x0000000183D018B0-0x0000000183D01940
	static ByteString() {} // 0x0000000183D017C0-0x0000000183D018B0

	// Methods
	// [XID] // 0x0000000189777100-0x0000000189777120
	internal static ByteString AttachBytes(byte[] bytes) => default; // 0x0000000183D00FF0-0x0000000183D010C0
	// [XID] // 0x000000018977E7E0-0x000000018977E800
	public void ResetBytes(byte[] bytes) {} // 0x0000000183D00880-0x0000000183D00A50
	// [XID] // 0x0000000189785FD0-0x0000000189785FF0
	public byte[] GetBytes() => default; // 0x0000000183CFFA90-0x0000000183CFFB30
	// [XID] // 0x00000001897A4340-0x00000001897A4360
	public byte[] ToByteArray() => default; // 0x0000000183D00520-0x0000000183D00620
	// [XID] // 0x00000001897AB8A0-0x00000001897AB8C0
	public string ToBase64() => default; // 0x0000000183D00F20-0x0000000183D00FF0
	// [XID] // 0x00000001897B37F0-0x00000001897B3810
	public static ByteString FromBase64(string bytes) => default; // 0x0000000183D01250-0x0000000183D013B0
	// [XID] // 0x00000001897BB630-0x00000001897BB650
	public static ByteString FromStream(Stream stream) => default; // 0x0000000183D00620-0x0000000183D00880
	// [IDTag] // 0x00000001897C2E40-0x00000001897C2E80
	// [XID] // 0x00000001897C2E40-0x00000001897C2E80
	public static ByteString CopyFrom(params /* 0x000000018989F6F0-0x000000018989F700 */ byte[] bytes) => default; // 0x0000000183CFFDF0-0x0000000183CFFF00
	// [IDTag] // 0x00000001897D4DE0-0x00000001897D4E20
	// [XID] // 0x00000001897D4DE0-0x00000001897D4E20
	public static ByteString CopyFrom(byte[] bytes, int offset, int count) => default; // 0x0000000183CFFCC0-0x0000000183CFFDF0
	// [IDTag] // 0x00000001897DF470-0x00000001897DF4B0
	// [XID] // 0x00000001897DF470-0x00000001897DF4B0
	public static ByteString CopyFrom(string text, Encoding encoding) => default; // 0x0000000183CFFF00-0x0000000183D00000
	// [XID] // 0x00000001897E9EB0-0x00000001897E9ED0
	public static ByteString CopyFromUtf8(string text) => default; // 0x0000000183D00420-0x0000000183D00520
	// [XID] // 0x00000001897F93E0-0x00000001897F9400
	public string ToString(Encoding encoding) => default; // 0x0000000183D00160-0x0000000183D00250
	// [XID] // 0x0000000189800980-0x00000001898009A0
	public string ToStringUtf8() => default; // 0x0000000183D01490-0x0000000183D01560
	// [XID] // 0x0000000189807F70-0x0000000189807F90
	public IEnumerator<byte> GetEnumerator() => default; // 0x0000000183D00A50-0x0000000183D00B10
	// [XID] // 0x000000018980F910-0x000000018980F930
	IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000183D01710-0x0000000183D017C0
	// [XID] // 0x0000000189816F70-0x0000000189816F90
	public CodedInputStream CreateCodedInput() => default; // 0x0000000183D01560-0x0000000183D01630
	// [XID] // 0x0000000189734CF0-0x0000000189734D10
	public static bool operator ==(ByteString lhs, ByteString rhs) => default; // 0x0000000183D00D50-0x0000000183D00F20
	// [XID] // 0x000000018977F600-0x000000018977F620
	public static bool operator !=(ByteString lhs, ByteString rhs) => default; // 0x0000000183D010C0-0x0000000183D011A0
	// [IDTag] // 0x000000018982D3E0-0x000000018982D420
	// [XID] // 0x000000018982D3E0-0x000000018982D420
	public override bool Equals(object obj) => default; // 0x0000000183D00330-0x0000000183D00420
	// [XID] // 0x0000000189837A40-0x0000000189837A60
	public override int GetHashCode() => default; // 0x0000000183D00B10-0x0000000183D00C00
	// [IDTag] // 0x000000018983F170-0x000000018983F1B0
	// [XID] // 0x000000018983F170-0x000000018983F1B0
	public bool Equals(ByteString other) => default; // 0x0000000183D00250-0x0000000183D00330
	// [XID] // 0x00000001898493F0-0x0000000189849410
	internal void WriteRawBytesTo(CodedOutputStream outputStream) {} // 0x0000000183CFFB30-0x0000000183CFFC10
	// [XID] // 0x0000000189850B70-0x0000000189850B90
	public void CopyTo(byte[] array, int position) {} // 0x0000000183D00070-0x0000000183D00160
	// [XID] // 0x0000000189857FA0-0x0000000189857FC0
	public void WriteTo(Stream outputStream) {} // 0x0000000183D01630-0x0000000183D01710
}

