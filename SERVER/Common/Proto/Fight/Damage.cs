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
            "aHQiiQEKDEF0dGFja2VySW5mbxITCgthdHRhY2tlcl9pZBgBIAEoBRI+Cg1h",
            "dHRhY2tlcl90eXBlGAIgASgOMicuTU1PUlBHLkNvbW1vbi5Qcm90by5GaWdo",
            "dC5BdHRhY2tlclR5cGUSEgoIc2tpbGxfaWQYAyABKAVIAEIQCg5hdHRhY2tl",
            "cl92YWx1ZSLNAQoKRGFtYWdlSW5mbxIRCgl0YXJnZXRfaWQYAiABKAUSPgoN",
            "YXR0YWNrZXJfaW5mbxgDIAEoCzInLk1NT1JQRy5Db21tb24uUHJvdG8uRmln",
            "aHQuQXR0YWNrZXJJbmZvEg4KBmFtb3VudBgEIAEoBRI6CgtkYW1hZ2VfdHlw",
            "ZRgFIAEoDjIlLk1NT1JQRy5Db21tb24uUHJvdG8uRmlnaHQuRGFtYWdlVHlw",
            "ZRIPCgdpc19jcml0GAYgASgIEg8KB2lzX21pc3MYByABKAgiSQoSRW50aXR5",
            "SHVydFJlc3BvbnNlEjMKBGluZm8YASABKAsyJS5NTU9SUEcuQ29tbW9uLlBy",
            "b3RvLkZpZ2h0LkRhbWFnZUluZm8qGQoMQXR0YWNrZXJUeXBlEgkKBVNraWxs",
            "EAAqPgoKRGFtYWdlVHlwZRILCgdVTktOT1dOEAASDAoIUEhZU0lDQUwQARIL",
            "CgdNQUdJQ0FMEAISCAoEUkVBTBADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MMORPG.Common.Proto.Fight.AttackerType), typeof(global::MMORPG.Common.Proto.Fight.DamageType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MMORPG.Common.Proto.Fight.AttackerInfo), global::MMORPG.Common.Proto.Fight.AttackerInfo.Parser, new[]{ "AttackerId", "AttackerType", "SkillId" }, new[]{ "AttackerValue" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MMORPG.Common.Proto.Fight.DamageInfo), global::MMORPG.Common.Proto.Fight.DamageInfo.Parser, new[]{ "TargetId", "AttackerInfo", "Amount", "DamageType", "IsCrit", "IsMiss" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MMORPG.Common.Proto.Fight.EntityHurtResponse), global::MMORPG.Common.Proto.Fight.EntityHurtResponse.Parser, new[]{ "Info" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum AttackerType {
    [pbr::OriginalName("Skill")] Skill = 0,
  }

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
  public sealed partial class AttackerInfo : pb::IMessage<AttackerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AttackerInfo> _parser = new pb::MessageParser<AttackerInfo>(() => new AttackerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AttackerInfo> Parser { get { return _parser; } }

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
    public AttackerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AttackerInfo(AttackerInfo other) : this() {
      attackerId_ = other.attackerId_;
      attackerType_ = other.attackerType_;
      switch (other.AttackerValueCase) {
        case AttackerValueOneofCase.SkillId:
          SkillId = other.SkillId;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AttackerInfo Clone() {
      return new AttackerInfo(this);
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

    /// <summary>Field number for the "attacker_type" field.</summary>
    public const int AttackerTypeFieldNumber = 2;
    private global::MMORPG.Common.Proto.Fight.AttackerType attackerType_ = global::MMORPG.Common.Proto.Fight.AttackerType.Skill;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MMORPG.Common.Proto.Fight.AttackerType AttackerType {
      get { return attackerType_; }
      set {
        attackerType_ = value;
      }
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SkillId {
      get { return attackerValueCase_ == AttackerValueOneofCase.SkillId ? (int) attackerValue_ : 0; }
      set {
        attackerValue_ = value;
        attackerValueCase_ = AttackerValueOneofCase.SkillId;
      }
    }

    private object attackerValue_;
    /// <summary>Enum of possible cases for the "attacker_value" oneof.</summary>
    public enum AttackerValueOneofCase {
      None = 0,
      SkillId = 3,
    }
    private AttackerValueOneofCase attackerValueCase_ = AttackerValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AttackerValueOneofCase AttackerValueCase {
      get { return attackerValueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAttackerValue() {
      attackerValueCase_ = AttackerValueOneofCase.None;
      attackerValue_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AttackerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AttackerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AttackerId != other.AttackerId) return false;
      if (AttackerType != other.AttackerType) return false;
      if (SkillId != other.SkillId) return false;
      if (AttackerValueCase != other.AttackerValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AttackerId != 0) hash ^= AttackerId.GetHashCode();
      if (AttackerType != global::MMORPG.Common.Proto.Fight.AttackerType.Skill) hash ^= AttackerType.GetHashCode();
      if (attackerValueCase_ == AttackerValueOneofCase.SkillId) hash ^= SkillId.GetHashCode();
      hash ^= (int) attackerValueCase_;
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
      if (AttackerType != global::MMORPG.Common.Proto.Fight.AttackerType.Skill) {
        output.WriteRawTag(16);
        output.WriteEnum((int) AttackerType);
      }
      if (attackerValueCase_ == AttackerValueOneofCase.SkillId) {
        output.WriteRawTag(24);
        output.WriteInt32(SkillId);
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
      if (AttackerType != global::MMORPG.Common.Proto.Fight.AttackerType.Skill) {
        output.WriteRawTag(16);
        output.WriteEnum((int) AttackerType);
      }
      if (attackerValueCase_ == AttackerValueOneofCase.SkillId) {
        output.WriteRawTag(24);
        output.WriteInt32(SkillId);
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
      if (AttackerType != global::MMORPG.Common.Proto.Fight.AttackerType.Skill) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AttackerType);
      }
      if (attackerValueCase_ == AttackerValueOneofCase.SkillId) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SkillId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AttackerInfo other) {
      if (other == null) {
        return;
      }
      if (other.AttackerId != 0) {
        AttackerId = other.AttackerId;
      }
      if (other.AttackerType != global::MMORPG.Common.Proto.Fight.AttackerType.Skill) {
        AttackerType = other.AttackerType;
      }
      switch (other.AttackerValueCase) {
        case AttackerValueOneofCase.SkillId:
          SkillId = other.SkillId;
          break;
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
            AttackerType = (global::MMORPG.Common.Proto.Fight.AttackerType) input.ReadEnum();
            break;
          }
          case 24: {
            SkillId = input.ReadInt32();
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
            AttackerType = (global::MMORPG.Common.Proto.Fight.AttackerType) input.ReadEnum();
            break;
          }
          case 24: {
            SkillId = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

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
      get { return global::MMORPG.Common.Proto.Fight.DamageReflection.Descriptor.MessageTypes[1]; }
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
      targetId_ = other.targetId_;
      attackerInfo_ = other.attackerInfo_ != null ? other.attackerInfo_.Clone() : null;
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

    /// <summary>Field number for the "attacker_info" field.</summary>
    public const int AttackerInfoFieldNumber = 3;
    private global::MMORPG.Common.Proto.Fight.AttackerInfo attackerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MMORPG.Common.Proto.Fight.AttackerInfo AttackerInfo {
      get { return attackerInfo_; }
      set {
        attackerInfo_ = value;
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
      if (TargetId != other.TargetId) return false;
      if (!object.Equals(AttackerInfo, other.AttackerInfo)) return false;
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
      if (TargetId != 0) hash ^= TargetId.GetHashCode();
      if (attackerInfo_ != null) hash ^= AttackerInfo.GetHashCode();
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
      if (TargetId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TargetId);
      }
      if (attackerInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AttackerInfo);
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
      if (TargetId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TargetId);
      }
      if (attackerInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AttackerInfo);
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
      if (TargetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TargetId);
      }
      if (attackerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AttackerInfo);
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
      if (other.TargetId != 0) {
        TargetId = other.TargetId;
      }
      if (other.attackerInfo_ != null) {
        if (attackerInfo_ == null) {
          AttackerInfo = new global::MMORPG.Common.Proto.Fight.AttackerInfo();
        }
        AttackerInfo.MergeFrom(other.AttackerInfo);
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
          case 16: {
            TargetId = input.ReadInt32();
            break;
          }
          case 26: {
            if (attackerInfo_ == null) {
              AttackerInfo = new global::MMORPG.Common.Proto.Fight.AttackerInfo();
            }
            input.ReadMessage(AttackerInfo);
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
          case 16: {
            TargetId = input.ReadInt32();
            break;
          }
          case 26: {
            if (attackerInfo_ == null) {
              AttackerInfo = new global::MMORPG.Common.Proto.Fight.AttackerInfo();
            }
            input.ReadMessage(AttackerInfo);
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
      get { return global::MMORPG.Common.Proto.Fight.DamageReflection.Descriptor.MessageTypes[2]; }
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
      info_ = other.info_ != null ? other.info_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityHurtResponse Clone() {
      return new EntityHurtResponse(this);
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 1;
    private global::MMORPG.Common.Proto.Fight.DamageInfo info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MMORPG.Common.Proto.Fight.DamageInfo Info {
      get { return info_; }
      set {
        info_ = value;
      }
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
      if (!object.Equals(Info, other.Info)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (info_ != null) hash ^= Info.GetHashCode();
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
      if (info_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Info);
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
      if (info_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Info);
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
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
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
      if (other.info_ != null) {
        if (info_ == null) {
          Info = new global::MMORPG.Common.Proto.Fight.DamageInfo();
        }
        Info.MergeFrom(other.Info);
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
          case 10: {
            if (info_ == null) {
              Info = new global::MMORPG.Common.Proto.Fight.DamageInfo();
            }
            input.ReadMessage(Info);
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
            if (info_ == null) {
              Info = new global::MMORPG.Common.Proto.Fight.DamageInfo();
            }
            input.ReadMessage(Info);
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
