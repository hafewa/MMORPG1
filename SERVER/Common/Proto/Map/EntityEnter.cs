// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Map/EntityEnter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Common.Proto.Event.Map {

  /// <summary>Holder for reflection information generated from Map/EntityEnter.proto</summary>
  public static partial class EntityEnterReflection {

    #region Descriptor
    /// <summary>File descriptor for Map/EntityEnter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityEnterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVNYXAvRW50aXR5RW50ZXIucHJvdG8SFkNvbW1vbi5Qcm90by5FdmVudC5N",
            "YXAaF0VudGl0eS9FbnRpdHlUeXBlLnByb3RvGhlFbnRpdHkvTmV0VHJhbnNm",
            "b3JtLnByb3RvIicKEkVudGl0eUVudGVyUmVxdWVzdBIRCgllbnRpdHlfaWQY",
            "ASADKAUikAEKD0VudGl0eUVudGVyRGF0YRIRCgllbnRpdHlfaWQYASABKAUS",
            "NAoLZW50aXR5X3R5cGUYAiABKA4yHy5Db21tb24uUHJvdG8uRW50aXR5LkVu",
            "dGl0eVR5cGUSNAoJdHJhbnNmb3JtGAMgASgLMiEuQ29tbW9uLlByb3RvLkVu",
            "dGl0eS5OZXRUcmFuc2Zvcm0iTQoTRW50aXR5RW50ZXJSZXNwb25zZRI2CgVk",
            "YXRhcxgBIAMoCzInLkNvbW1vbi5Qcm90by5FdmVudC5NYXAuRW50aXR5RW50",
            "ZXJEYXRhYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.Proto.Entity.EntityTypeReflection.Descriptor, global::Common.Proto.Entity.NetTransformReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Proto.Event.Map.EntityEnterRequest), global::Common.Proto.Event.Map.EntityEnterRequest.Parser, new[]{ "EntityId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Proto.Event.Map.EntityEnterData), global::Common.Proto.Event.Map.EntityEnterData.Parser, new[]{ "EntityId", "EntityType", "Transform" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Proto.Event.Map.EntityEnterResponse), global::Common.Proto.Event.Map.EntityEnterResponse.Parser, new[]{ "Datas" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EntityEnterRequest : pb::IMessage<EntityEnterRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityEnterRequest> _parser = new pb::MessageParser<EntityEnterRequest>(() => new EntityEnterRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityEnterRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Proto.Event.Map.EntityEnterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityEnterRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityEnterRequest(EntityEnterRequest other) : this() {
      entityId_ = other.entityId_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityEnterRequest Clone() {
      return new EntityEnterRequest(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_entityId_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> entityId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> EntityId {
      get { return entityId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityEnterRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityEnterRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entityId_.Equals(other.entityId_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entityId_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      entityId_.WriteTo(output, _repeated_entityId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      entityId_.WriteTo(ref output, _repeated_entityId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += entityId_.CalculateSize(_repeated_entityId_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityEnterRequest other) {
      if (other == null) {
        return;
      }
      entityId_.Add(other.entityId_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            entityId_.AddEntriesFrom(input, _repeated_entityId_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10:
          case 8: {
            entityId_.AddEntriesFrom(ref input, _repeated_entityId_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class EntityEnterData : pb::IMessage<EntityEnterData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityEnterData> _parser = new pb::MessageParser<EntityEnterData>(() => new EntityEnterData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityEnterData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Proto.Event.Map.EntityEnterReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityEnterData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityEnterData(EntityEnterData other) : this() {
      entityId_ = other.entityId_;
      entityType_ = other.entityType_;
      transform_ = other.transform_ != null ? other.transform_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityEnterData Clone() {
      return new EntityEnterData(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private int entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "entity_type" field.</summary>
    public const int EntityTypeFieldNumber = 2;
    private global::Common.Proto.Entity.EntityType entityType_ = global::Common.Proto.Entity.EntityType.Player;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Common.Proto.Entity.EntityType EntityType {
      get { return entityType_; }
      set {
        entityType_ = value;
      }
    }

    /// <summary>Field number for the "transform" field.</summary>
    public const int TransformFieldNumber = 3;
    private global::Common.Proto.Entity.NetTransform transform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Common.Proto.Entity.NetTransform Transform {
      get { return transform_; }
      set {
        transform_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityEnterData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityEnterData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (EntityType != other.EntityType) return false;
      if (!object.Equals(Transform, other.Transform)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (EntityType != global::Common.Proto.Entity.EntityType.Player) hash ^= EntityType.GetHashCode();
      if (transform_ != null) hash ^= Transform.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EntityId);
      }
      if (EntityType != global::Common.Proto.Entity.EntityType.Player) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EntityType);
      }
      if (transform_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Transform);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EntityId);
      }
      if (EntityType != global::Common.Proto.Entity.EntityType.Player) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EntityType);
      }
      if (transform_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Transform);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EntityId);
      }
      if (EntityType != global::Common.Proto.Entity.EntityType.Player) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EntityType);
      }
      if (transform_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transform);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityEnterData other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.EntityType != global::Common.Proto.Entity.EntityType.Player) {
        EntityType = other.EntityType;
      }
      if (other.transform_ != null) {
        if (transform_ == null) {
          Transform = new global::Common.Proto.Entity.NetTransform();
        }
        Transform.MergeFrom(other.Transform);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EntityId = input.ReadInt32();
            break;
          }
          case 16: {
            EntityType = (global::Common.Proto.Entity.EntityType) input.ReadEnum();
            break;
          }
          case 26: {
            if (transform_ == null) {
              Transform = new global::Common.Proto.Entity.NetTransform();
            }
            input.ReadMessage(Transform);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            EntityId = input.ReadInt32();
            break;
          }
          case 16: {
            EntityType = (global::Common.Proto.Entity.EntityType) input.ReadEnum();
            break;
          }
          case 26: {
            if (transform_ == null) {
              Transform = new global::Common.Proto.Entity.NetTransform();
            }
            input.ReadMessage(Transform);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class EntityEnterResponse : pb::IMessage<EntityEnterResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityEnterResponse> _parser = new pb::MessageParser<EntityEnterResponse>(() => new EntityEnterResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityEnterResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Proto.Event.Map.EntityEnterReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityEnterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityEnterResponse(EntityEnterResponse other) : this() {
      datas_ = other.datas_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityEnterResponse Clone() {
      return new EntityEnterResponse(this);
    }

    /// <summary>Field number for the "datas" field.</summary>
    public const int DatasFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Common.Proto.Event.Map.EntityEnterData> _repeated_datas_codec
        = pb::FieldCodec.ForMessage(10, global::Common.Proto.Event.Map.EntityEnterData.Parser);
    private readonly pbc::RepeatedField<global::Common.Proto.Event.Map.EntityEnterData> datas_ = new pbc::RepeatedField<global::Common.Proto.Event.Map.EntityEnterData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Common.Proto.Event.Map.EntityEnterData> Datas {
      get { return datas_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityEnterResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityEnterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!datas_.Equals(other.datas_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= datas_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      datas_.WriteTo(output, _repeated_datas_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      datas_.WriteTo(ref output, _repeated_datas_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += datas_.CalculateSize(_repeated_datas_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityEnterResponse other) {
      if (other == null) {
        return;
      }
      datas_.Add(other.datas_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            datas_.AddEntriesFrom(input, _repeated_datas_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            datas_.AddEntriesFrom(ref input, _repeated_datas_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
