// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: sample.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Sample {
  public static partial class ReverseService
  {
    static readonly string __ServiceName = "sample.ReverseService";

    static readonly grpc::Marshaller<global::Sample.ReverseRequest> __Marshaller_sample_ReverseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sample.ReverseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Sample.ReverseReply> __Marshaller_sample_ReverseReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sample.ReverseReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Sample.ReverseRequest, global::Sample.ReverseReply> __Method_ReverseString = new grpc::Method<global::Sample.ReverseRequest, global::Sample.ReverseReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReverseString",
        __Marshaller_sample_ReverseRequest,
        __Marshaller_sample_ReverseReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Sample.SampleReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReverseService</summary>
    public abstract partial class ReverseServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Sample.ReverseReply> ReverseString(global::Sample.ReverseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReverseService</summary>
    public partial class ReverseServiceClient : grpc::ClientBase<ReverseServiceClient>
    {
      /// <summary>Creates a new client for ReverseService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReverseServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReverseService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReverseServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReverseServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReverseServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Sample.ReverseReply ReverseString(global::Sample.ReverseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReverseString(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Sample.ReverseReply ReverseString(global::Sample.ReverseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReverseString, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Sample.ReverseReply> ReverseStringAsync(global::Sample.ReverseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReverseStringAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Sample.ReverseReply> ReverseStringAsync(global::Sample.ReverseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReverseString, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ReverseServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReverseServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ReverseServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReverseString, serviceImpl.ReverseString).Build();
    }

  }
}
#endregion
