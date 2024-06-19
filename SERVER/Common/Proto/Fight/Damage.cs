// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Fight/Damage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MMORPG.Common.Proto.Fight {

  /// <summary>Holder for reflection information generated from Fight/Damage.proto</summary>
  public static partial class DamageReflection {

    #region Descriptor
    /// <summary>File descriptor for Fight/Damage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DamageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJGaWdodC9EYW1hZ2UucHJvdG8SGU1NT1JQRy5Db21tb24uUHJvdG8uRmln",
            "aHQitAEKCkRhbWFnZUluZm8SEwoLYXR0YWNrZXJfaWQYASABKAUSEQoJdGFy",
            "Z2V0X2lkGAIgASgFEhAKCHNraWxsX2lkGAMgASgFEg4KBmFtb3VudBgEIAEo",
            "BRI6CgtkYW1hZ2VfdHlwZRgFIAEoDjIlLk1NT1JQRy5Db21tb24uUHJvdG8u",
            "RmlnaHQuRGFtYWdlVHlwZRIPCgdpc19jcml0GAYgASgIEg8KB2lzX21pc3MY",
            "ByABKAgiTAoSRW50aXR5SHVydFJlc3BvbnNlEjYKB2RhbWFnZXMYASADKAsy",
            "JS5NTU9SUEcuQ29tbW9uLlByb3RvLkZpZ2h0LkRhbWFnZUluZm8qPgoKRGFt",
            "YWdlVHlwZRILCgdVTktOT1dOEAASDAoIUEhZU0lDQUwQARILCgdNQUdJQ0FM",
            "EAISCAoEUkVBTBADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MMORPG.Common.Proto.Fight.DamageType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MMORPG.Common.Proto.Fight.DamageInfo), global::MMORPG.Common.Proto.Fight.DamageInfo.Parser, new[]{ "AttackerId", "TargetId", "SkillId", "Amount", "DamageType", "IsCrit", "IsMiss" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MMORPG.Common.Proto.Fight.EntityHurtResponse), global::MMORPG.Common.Proto.Fight.EntityHurtResponse.Parser, new[]{ "Damages" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum DamageType {
    [pbr::OriginalName("UNKNOWN")] Unknown = 0,
    /// <summary>
    /// 物理伤害
    /// </summary>
    [pbr::OriginalName("PHYSICAL")] Physical = 1,
    /// <summary>
    /// 魔法伤害
    /// </summary>
    [pbr::OriginalName("MAGICAL")] Magical = 2,
    /// <summary>
    /// 真实伤害
    /// </summary>
    [pbr::OriginalName("REAL")] Real = 3,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DamageInfo : pb::IMessage<DamageInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DamageInfo> _parser = new pb::MessageParser<DamageInfo>(() => new DamageInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DamageInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MMORPG.Common.Proto.Fight.DamageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DamageInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DamageInfo(DamageInfo other) : this() {
      attackerId_ = other.attackerId_;
      targetId_ = other.targetId_;
      skillId_ = other.skillId_;
      amount_ = other.amount_;
      damageType_ = other.damageType_;
      isCrit_ = other.isCrit_;
      isMiss_ = other.isMiss_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DamageInfo Clone() {
      return new DamageInfo(this);
    }

    /// <summary>Field number for the "attacker_id" field.</summary>
    public const int AttackerIdFieldNumber = 1;
    private int attackerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AttackerId {
      get { return attackerId_; }
      set {
        attackerId_ = value;
      }
    }

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 2;
    private int targetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int TargetId {
      get { return targetId_; }
      set {
        targetId_ = value;
      }
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 3;
    private int skillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SkillId {
      get { return skillId_; }
      set {
        skillId_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 4;
    private int amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "damage_type" field.</summary>
    public const int DamageTypeFieldNumber = 5;
    private global::MMORPG.Common.Proto.Fight.DamageType damageType_ = global::MMORPG.Common.Proto.Fight.DamageType.Unknown;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MMORPG.Common.Proto.Fight.DamageType DamageType {
      get { return damageType_; }
      set {
        damageType_ = value;
      }
    }

    /// <summary>Field number for the "is_crit" field.</summary>
    public const int IsCritFieldNumber = 6;
    private bool isCrit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCrit {
      get { return isCrit_; }
      set {
        isCrit_ = value;
      }
    }

    /// <summary>Field number for the "is_miss" field.</summary>
    public const int IsMissFieldNumber = 7;
    private bool isMiss_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMiss {
      get { return isMiss_; }
      set {
        isMiss_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DamageInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DamageInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AttackerId != other.AttackerId) return false;
      if (TargetId != other.TargetId) return false;
      if (SkillId != other.SkillId) return false;
      if (Amount != other.Amount) return false;
      if (DamageType != other.DamageType) return false;
      if (IsCrit != other.IsCrit) return false;
      if (IsMiss != other.IsMiss) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AttackerId != 0) hash ^= AttackerId.GetHashCode();
      if (TargetId != 0) hash ^= TargetId.GetHashCode();
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
      if (Amount != 0) hash ^= Amount.GetHashCode();
      if (DamageType != global::MMORPG.Common.Proto.Fight.DamageType.Unknown) hash ^= DamageType.GetHashCode();
      if (IsCrit != false) hash ^= IsCrit.GetHashCode();
      if (IsMiss != false) hash ^= IsMiss.GetHashCode();
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
      if (AttackerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(AttackerId);
      }
      if (TargetId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TargetId);
      }
      if (SkillId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SkillId);
      }
      if (Amount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Amount);
      }
      if (DamageType != global::MMORPG.Common.Proto.Fight.DamageType.Unknown) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DamageType);
      }
      if (IsCrit != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsCrit);
      }
      if (IsMiss != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsMiss);
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
      if (AttackerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(AttackerId);
      }
      if (TargetId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TargetId);
      }
      if (SkillId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SkillId);
      }
      if (Amount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Amount);
      }
      if (DamageType != global::MMORPG.Common.Proto.Fight.DamageType.Unknown) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DamageType);
      }
      if (IsCrit != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsCrit);
      }
      if (IsMiss != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsMiss);
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
      if (AttackerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AttackerId);
      }
      if (TargetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TargetId);
      }
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SkillId);
      }
      if (Amount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
      }
      if (DamageType != global::MMORPG.Common.Proto.Fight.DamageType.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DamageType);
      }
      if (IsCrit != false) {
        size += 1 + 1;
      }
      if (IsMiss != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DamageInfo other) {
      if (other == null) {
        return;
      }
      if (other.AttackerId != 0) {
        AttackerId = other.AttackerId;
      }
      if (other.TargetId != 0) {
        TargetId = other.TargetId;
      }
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
      }
      if (other.Amount != 0) {
        Amount = other.Amount;
      }
      if (other.DamageType != global::MMORPG.Common.Proto.Fight.DamageType.Unknown) {
        DamageType = other.DamageType;
      }
      if (other.IsCrit != false) {
        IsCrit = other.IsCrit;
      }
      if (other.IsMiss != false) {
        IsMiss = other.IsMiss;
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
            AttackerId = input.ReadInt32();
            break;
          }
          case 16: {
            TargetId = input.ReadInt32();
            break;
          }
          case 24: {
            SkillId = input.ReadInt32();
            break;
          }
          case 32: {
            Amount = input.ReadInt32();
            break;
          }
          case 40: {
            DamageType = (global::MMORPG.Common.Proto.Fight.DamageType) input.ReadEnum();
            break;
          }
          case 48: {
            IsCrit = input.ReadBool();
            break;
          }
          case 56: {
            IsMiss = input.ReadBool();
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
            AttackerId = input.ReadInt32();
            break;
          }
          case 16: {
            TargetId = input.ReadInt32();
            break;
          }
          case 24: {
            SkillId = input.ReadInt32();
            break;
          }
          case 32: {
            Amount = input.ReadInt32();
            break;
          }
          case 40: {
            DamageType = (global::MMORPG.Common.Proto.Fight.DamageType) input.ReadEnum();
            break;
          }
          case 48: {
            IsCrit = input.ReadBool();
            break;
          }
          case 56: {
            IsMiss = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EntityHurtResponse : pb::IMessage<EntityHurtResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityHurtResponse> _parser = new pb::MessageParser<EntityHurtResponse>(() => new EntityHurtResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityHurtResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MMORPG.Common.Proto.Fight.DamageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityHurtResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityHurtResponse(EntityHurtResponse other) : this() {
      damages_ = other.damages_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityHurtResponse Clone() {
      return new EntityHurtResponse(this);
    }

    /// <summary>Field number for the "damages" field.</summary>
    public const int DamagesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::MMORPG.Common.Proto.Fight.DamageInfo> _repeated_damages_codec
        = pb::FieldCodec.ForMessage(10, global::MMORPG.Common.Proto.Fight.DamageInfo.Parser);
    private readonly pbc::RepeatedField<global::MMORPG.Common.Proto.Fight.DamageInfo> damages_ = new pbc::RepeatedField<global::MMORPG.Common.Proto.Fight.DamageInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MMORPG.Common.Proto.Fight.DamageInfo> Damages {
      get { return damages_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityHurtResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityHurtResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!damages_.Equals(other.damages_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= damages_.GetHashCode();
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
      damages_.WriteTo(output, _repeated_damages_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      damages_.WriteTo(ref output, _repeated_damages_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += damages_.CalculateSize(_repeated_damages_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityHurtResponse other) {
      if (other == null) {
        return;
      }
      damages_.Add(other.damages_);
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
            damages_.AddEntriesFrom(input, _repeated_damages_codec);
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
            damages_.AddEntriesFrom(ref input, _repeated_damages_codec);
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
