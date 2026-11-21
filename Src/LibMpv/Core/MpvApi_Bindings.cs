using System.Security;

namespace HanumanInstitute.LibMpv.Core;

public static unsafe partial class MpvApi
{
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_abort_async_command", ExactSpelling = true)]
    public static extern void AbortAsyncCommand(MpvHandle* ctx, ulong replyUserData);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_client_api_version", ExactSpelling = true)]
    public static extern ulong ClientApiVersion();
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_client_id", ExactSpelling = true)]
    public static extern long ClientId(MpvHandle* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_client_name", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string ClientName(MpvHandle* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_command", ExactSpelling = true)]
    public static extern int Command(MpvHandle* ctx, byte** args);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_command_async", ExactSpelling = true)]
    public static extern int CommandAsync(MpvHandle* ctx, ulong replyUserData, byte** args);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_command_node", ExactSpelling = true)]
    public static extern int CommandNode(MpvHandle* ctx, MpvNode* args, MpvNode* result);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_command_node_async", ExactSpelling = true)]
    public static extern int CommandNodeAsync(MpvHandle* ctx, ulong replyUserData, MpvNode* args);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_command_ret", ExactSpelling = true)]
    public static extern int CommandRet(MpvHandle* ctx, byte** args, MpvNode* result);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_command_string", ExactSpelling = true)]
    public static extern int CommandString(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string args);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_create", ExactSpelling = true)]
    public static extern MpvHandle* Create();
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_create_client", ExactSpelling = true)]
    public static extern MpvHandle* CreateClient(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_create_weak_client", ExactSpelling = true)]
    public static extern MpvHandle* CreateWeakClient(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_del_property", ExactSpelling = true)]
    public static extern int DelProperty(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_destroy", ExactSpelling = true)]
    public static extern void Destroy(MpvHandle* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_error_string", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string ErrorString(int error);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_event_name", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public static extern string? EventName(MpvEventId eventId);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_event_to_node", ExactSpelling = true)]
    public static extern int EventToNode(MpvNode* dst, MpvEvent* src);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_free", ExactSpelling = true)]
    public static extern void Free(void* data);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_free_node_contents", ExactSpelling = true)]
    public static extern void FreeNodeContents(MpvNode* node);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_get_property", ExactSpelling = true)]
    public static extern int GetProperty(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, MpvFormat format, void* data);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_get_property_async", ExactSpelling = true)]
    public static extern int GetPropertyAsync(MpvHandle* ctx, ulong replyUserData, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, MpvFormat format);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_get_property_osd_string", ExactSpelling = true)]
    public static extern byte* GetPropertyOsdString(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_get_property_string", ExactSpelling = true)]
    public static extern byte* GetPropertyString(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_get_time_us", ExactSpelling = true)]
    public static extern long GetTimeUs(MpvHandle* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_get_wakeup_pipe", ExactSpelling = true)]
    public static extern int GetWakeupPipe(MpvHandle* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_hook_add", ExactSpelling = true)]
    public static extern int HookAdd(MpvHandle* ctx, ulong replyUserData, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int priority);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_hook_continue", ExactSpelling = true)]
    public static extern int HookContinue(MpvHandle* ctx, ulong id);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_initialize", ExactSpelling = true)]
    public static extern int Initialize(MpvHandle* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_load_config_file", ExactSpelling = true)]
    public static extern int LoadConfigFile(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_observe_property", ExactSpelling = true)]
    public static extern int ObserveProperty(MpvHandle* mpv, ulong replyUserData, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, MpvFormat format);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_render_context_create", ExactSpelling = true)]
    public static extern int RenderContextCreate(MpvRenderContext** res, MpvHandle* mpv, MpvRenderParam* @params);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_render_context_free", ExactSpelling = true)]
    public static extern void RenderContextFree(MpvRenderContext* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_render_context_get_info", ExactSpelling = true)]
    public static extern int RenderContextGetInfo(MpvRenderContext* ctx, MpvRenderParam param);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_render_context_render", ExactSpelling = true)]
    public static extern int RenderContextRender(MpvRenderContext* ctx, MpvRenderParam* @params);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_render_context_report_swap", ExactSpelling = true)]
    public static extern void RenderContextReportSwap(MpvRenderContext* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_render_context_set_parameter", ExactSpelling = true)]
    public static extern int RenderContextSetParameter(MpvRenderContext* ctx, MpvRenderParam param);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_render_context_set_update_callback", ExactSpelling = true)]
    public static extern void RenderContextSetUpdateCallback(MpvRenderContext* ctx, MpvRenderContextSetUpdateCallbackCallbackFunc callback, void* callbackCtx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_render_context_update", ExactSpelling = true)]
    public static extern ulong RenderContextUpdate(MpvRenderContext* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_request_event", ExactSpelling = true)]
    public static extern int RequestEvent(MpvHandle* ctx, MpvEventId eventId, int enable);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_request_log_messages", ExactSpelling = true)]
    public static extern int RequestLogMessages(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string minLevel);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_set_option", ExactSpelling = true)]
    public static extern int SetOption(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, MpvFormat format, void* data);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_set_option_string", ExactSpelling = true)]
    public static extern int SetOptionString(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string data);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_set_property", ExactSpelling = true)]
    public static extern int SetProperty(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, MpvFormat format, void* data);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_set_property_async", ExactSpelling = true)]
    public static extern int SetPropertyAsync(MpvHandle* ctx, ulong replyUserData, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, MpvFormat format, void* data);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_set_property_string", ExactSpelling = true)]
    public static extern int SetPropertyString(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string data);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_set_wakeup_callback", ExactSpelling = true)]
    public static extern void SetWakeupCallback(MpvHandle* ctx, MpvSetWakeupCallbackCbFunc cb, void* d);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_stream_cb_add_ro", ExactSpelling = true)]
    public static extern int StreamCbAddRo(MpvHandle* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string protocol, void* userData, MpvStreamCbAddRoOpenFnFunc openFn);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_terminate_destroy", ExactSpelling = true)]
    public static extern void TerminateDestroy(MpvHandle* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_unobserve_property", ExactSpelling = true)]
    public static extern int UnobserveProperty(MpvHandle* mpv, ulong registeredReplyUserData);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_wait_async_requests", ExactSpelling = true)]
    public static extern void WaitAsyncRequests(MpvHandle* ctx);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_wait_event", ExactSpelling = true)]
    public static extern MpvEvent* WaitEvent(MpvHandle* ctx, double timeout);
    
    [SuppressUnmanagedCodeSecurity]
    [DllImport("libmpv", CallingConvention = CallingConvention.Cdecl, EntryPoint = "mpv_wakeup", ExactSpelling = true)]
    public static extern void Wakeup(MpvHandle* ctx);
}
