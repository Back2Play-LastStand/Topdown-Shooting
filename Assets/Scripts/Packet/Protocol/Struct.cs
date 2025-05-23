// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Struct.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protocol {

  /// <summary>Holder for reflection information generated from Struct.proto</summary>
  public static partial class StructReflection {

    #region Descriptor
    /// <summary>File descriptor for Struct.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StructReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxTdHJ1Y3QucHJvdG8SCFByb3RvY29sGgpFbnVtLnByb3RvImUKCk9iamVj",
            "dEluZm8SEAoIb2JqZWN0SWQYASABKAQSDAoEbmFtZRgCIAEoCRIOCgZoZWFs",
            "dGgYAyABKA0SJwoHcG9zSW5mbxgEIAEoCzIWLlByb3RvY29sLlBvc2l0aW9u",
            "SW5mbyJOCgxQb3NpdGlvbkluZm8SDAoEcG9zWBgBIAEoAhIMCgRwb3NZGAIg",
            "ASgCEiIKB21vdmVEaXIYAyABKA4yES5Qcm90b2NvbC5Nb3ZlRGlyYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Protocol.EnumReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.ObjectInfo), global::Protocol.ObjectInfo.Parser, new[]{ "ObjectId", "Name", "Health", "PosInfo" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.PositionInfo), global::Protocol.PositionInfo.Parser, new[]{ "PosX", "PosY", "MoveDir" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ObjectInfo : pb::IMessage<ObjectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ObjectInfo> _parser = new pb::MessageParser<ObjectInfo>(() => new ObjectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ObjectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.StructReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObjectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObjectInfo(ObjectInfo other) : this() {
      objectId_ = other.objectId_;
      name_ = other.name_;
      health_ = other.health_;
      posInfo_ = other.posInfo_ != null ? other.posInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObjectInfo Clone() {
      return new ObjectInfo(this);
    }

    /// <summary>Field number for the "objectId" field.</summary>
    public const int ObjectIdFieldNumber = 1;
    private ulong objectId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ObjectId {
      get { return objectId_; }
      set {
        objectId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "health" field.</summary>
    public const int HealthFieldNumber = 3;
    private uint health_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Health {
      get { return health_; }
      set {
        health_ = value;
      }
    }

    /// <summary>Field number for the "posInfo" field.</summary>
    public const int PosInfoFieldNumber = 4;
    private global::Protocol.PositionInfo posInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Protocol.PositionInfo PosInfo {
      get { return posInfo_; }
      set {
        posInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ObjectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ObjectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ObjectId != other.ObjectId) return false;
      if (Name != other.Name) return false;
      if (Health != other.Health) return false;
      if (!object.Equals(PosInfo, other.PosInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ObjectId != 0UL) hash ^= ObjectId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Health != 0) hash ^= Health.GetHashCode();
      if (posInfo_ != null) hash ^= PosInfo.GetHashCode();
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
      if (ObjectId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(ObjectId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Health != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Health);
      }
      if (posInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PosInfo);
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
      if (ObjectId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(ObjectId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Health != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Health);
      }
      if (posInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PosInfo);
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
      if (ObjectId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ObjectId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Health != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Health);
      }
      if (posInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PosInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ObjectInfo other) {
      if (other == null) {
        return;
      }
      if (other.ObjectId != 0UL) {
        ObjectId = other.ObjectId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Health != 0) {
        Health = other.Health;
      }
      if (other.posInfo_ != null) {
        if (posInfo_ == null) {
          PosInfo = new global::Protocol.PositionInfo();
        }
        PosInfo.MergeFrom(other.PosInfo);
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
            ObjectId = input.ReadUInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Health = input.ReadUInt32();
            break;
          }
          case 34: {
            if (posInfo_ == null) {
              PosInfo = new global::Protocol.PositionInfo();
            }
            input.ReadMessage(PosInfo);
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
            ObjectId = input.ReadUInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Health = input.ReadUInt32();
            break;
          }
          case 34: {
            if (posInfo_ == null) {
              PosInfo = new global::Protocol.PositionInfo();
            }
            input.ReadMessage(PosInfo);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class PositionInfo : pb::IMessage<PositionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PositionInfo> _parser = new pb::MessageParser<PositionInfo>(() => new PositionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PositionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.StructReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PositionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PositionInfo(PositionInfo other) : this() {
      posX_ = other.posX_;
      posY_ = other.posY_;
      moveDir_ = other.moveDir_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PositionInfo Clone() {
      return new PositionInfo(this);
    }

    /// <summary>Field number for the "posX" field.</summary>
    public const int PosXFieldNumber = 1;
    private float posX_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float PosX {
      get { return posX_; }
      set {
        posX_ = value;
      }
    }

    /// <summary>Field number for the "posY" field.</summary>
    public const int PosYFieldNumber = 2;
    private float posY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float PosY {
      get { return posY_; }
      set {
        posY_ = value;
      }
    }

    /// <summary>Field number for the "moveDir" field.</summary>
    public const int MoveDirFieldNumber = 3;
    private global::Protocol.MoveDir moveDir_ = global::Protocol.MoveDir.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Protocol.MoveDir MoveDir {
      get { return moveDir_; }
      set {
        moveDir_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PositionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PositionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosX, other.PosX)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosY, other.PosY)) return false;
      if (MoveDir != other.MoveDir) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PosX != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosX);
      if (PosY != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosY);
      if (MoveDir != global::Protocol.MoveDir.None) hash ^= MoveDir.GetHashCode();
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
      if (PosX != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(PosX);
      }
      if (PosY != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(PosY);
      }
      if (MoveDir != global::Protocol.MoveDir.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MoveDir);
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
      if (PosX != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(PosX);
      }
      if (PosY != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(PosY);
      }
      if (MoveDir != global::Protocol.MoveDir.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MoveDir);
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
      if (PosX != 0F) {
        size += 1 + 4;
      }
      if (PosY != 0F) {
        size += 1 + 4;
      }
      if (MoveDir != global::Protocol.MoveDir.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MoveDir);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PositionInfo other) {
      if (other == null) {
        return;
      }
      if (other.PosX != 0F) {
        PosX = other.PosX;
      }
      if (other.PosY != 0F) {
        PosY = other.PosY;
      }
      if (other.MoveDir != global::Protocol.MoveDir.None) {
        MoveDir = other.MoveDir;
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
          case 13: {
            PosX = input.ReadFloat();
            break;
          }
          case 21: {
            PosY = input.ReadFloat();
            break;
          }
          case 24: {
            MoveDir = (global::Protocol.MoveDir) input.ReadEnum();
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
          case 13: {
            PosX = input.ReadFloat();
            break;
          }
          case 21: {
            PosY = input.ReadFloat();
            break;
          }
          case 24: {
            MoveDir = (global::Protocol.MoveDir) input.ReadEnum();
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
