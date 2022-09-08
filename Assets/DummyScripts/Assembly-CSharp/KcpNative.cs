/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class KcpNative // TypeDefIndex: 21726
{
	// Fields
	private const string LIB = "mihoyonet"; // Metadata: 0x00AFFD46

	// Nested types
	// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
	public delegate void log_cb(int level, IntPtr text, IntPtr length); // TypeDefIndex: 21727; 0x0000000181E0ECD0-0x0000000181E0EEA0

	// Constructors
	public KcpNative() {} // 0x0000000181E15A00-0x0000000181E15A60

	// Methods
	public static extern IntPtr kcp_client_create(ref KcpClientInitParams param); // 0x0000000181E14E30-0x0000000181E14F20
	public static extern void kcp_client_destroy(IntPtr kcp_client); // 0x0000000181E15820-0x0000000181E15910
	public static extern int kcp_client_connect(IntPtr kcp_client, ref NativeKcpAddress address, uint token, uint data); // 0x0000000181E14C30-0x0000000181E14D40
	public static extern void kcp_client_disconnect(IntPtr kcp_client, uint token, uint data); // 0x0000000181E14F20-0x0000000181E15020
	public static extern int kcp_client_reconnect(IntPtr kcp_client, uint token, uint data); // 0x0000000181E15110-0x0000000181E15210
	public static unsafe extern KcpPacket* kcp_packet_create(byte* data, int len); // 0x0000000181E14940-0x0000000181E14A40
	public static unsafe extern KcpPacket* kcp_packet_create(byte[] data, int len); // 0x0000000181E14A40-0x0000000181E14B40
	public static unsafe extern void kcp_packet_destroy(KcpPacket* packet); // 0x0000000181E153F0-0x0000000181E154E0
	public static unsafe extern int kcp_client_send_packet(IntPtr kcp_client, KcpPacket* packet); // 0x0000000181E154E0-0x0000000181E155E0
	public static extern int kcp_client_try_deque_event(IntPtr kcp_client, ref KcpEvent evt); // 0x0000000181E156D0-0x0000000181E15820
	public static extern void kcp_set_log_callback(IntPtr log_callback); // 0x0000000181E155E0-0x0000000181E156D0
	public static extern void kcp_client_set_log_mask(IntPtr kcp_client, int log_mask); // 0x0000000181E14B40-0x0000000181E14C30
	public static extern int kcp_client_network_thread(IntPtr kcp_client); // 0x0000000181E15210-0x0000000181E15300
	public static extern int kcp_client_get_rtt(IntPtr kcp_client); // 0x0000000181E15020-0x0000000181E15110
	public static extern int kcp_client_get_packet_loss(IntPtr kcp_client); // 0x0000000181E14D40-0x0000000181E14E30
	public static extern int kcp_client_get_rx_bandwidth(IntPtr kcp_client); // 0x0000000181E15300-0x0000000181E153F0
	public static extern int kcp_client_get_tx_bandwidth(IntPtr kcp_client); // 0x0000000181E15910-0x0000000181E15A00
}

