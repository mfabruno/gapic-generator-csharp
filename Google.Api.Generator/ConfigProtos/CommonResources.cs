// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: common_resources.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api.Generator {

  /// <summary>Holder for reflection information generated from common_resources.proto</summary>
  public static partial class CommonResourcesReflection {

    #region Descriptor
    /// <summary>File descriptor for common_resources.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonResourcesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZjb21tb25fcmVzb3VyY2VzLnByb3RvEhRnb29nbGUuYXBpLmdlbmVyYXRv",
            "ciJwCg5Db21tb25SZXNvdXJjZRIMCgR0eXBlGAEgASgJEhsKE2NzaGFycF9w",
            "YWNrYWdlX25hbWUYAiABKAkSGAoQY3NoYXJwX25hbWVzcGFjZRgDIAEoCRIZ",
            "ChFjc2hhcnBfY2xhc3NfbmFtZRgEIAEoCSJRCg9Db21tb25SZXNvdXJjZXMS",
            "PgoQY29tbW9uX3Jlc291cmNlcxgBIAMoCzIkLmdvb2dsZS5hcGkuZ2VuZXJh",
            "dG9yLkNvbW1vblJlc291cmNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Generator.CommonResource), global::Google.Api.Generator.CommonResource.Parser, new[]{ "Type", "CsharpPackageName", "CsharpNamespace", "CsharpClassName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Generator.CommonResources), global::Google.Api.Generator.CommonResources.Parser, new[]{ "CommonResources_" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommonResource : pb::IMessage<CommonResource> {
    private static readonly pb::MessageParser<CommonResource> _parser = new pb::MessageParser<CommonResource>(() => new CommonResource());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonResource> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.Generator.CommonResourcesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonResource() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonResource(CommonResource other) : this() {
      type_ = other.type_;
      csharpPackageName_ = other.csharpPackageName_;
      csharpNamespace_ = other.csharpNamespace_;
      csharpClassName_ = other.csharpClassName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonResource Clone() {
      return new CommonResource(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "csharp_package_name" field.</summary>
    public const int CsharpPackageNameFieldNumber = 2;
    private string csharpPackageName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CsharpPackageName {
      get { return csharpPackageName_; }
      set {
        csharpPackageName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "csharp_namespace" field.</summary>
    public const int CsharpNamespaceFieldNumber = 3;
    private string csharpNamespace_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CsharpNamespace {
      get { return csharpNamespace_; }
      set {
        csharpNamespace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "csharp_class_name" field.</summary>
    public const int CsharpClassNameFieldNumber = 4;
    private string csharpClassName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CsharpClassName {
      get { return csharpClassName_; }
      set {
        csharpClassName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonResource);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonResource other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (CsharpPackageName != other.CsharpPackageName) return false;
      if (CsharpNamespace != other.CsharpNamespace) return false;
      if (CsharpClassName != other.CsharpClassName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (CsharpPackageName.Length != 0) hash ^= CsharpPackageName.GetHashCode();
      if (CsharpNamespace.Length != 0) hash ^= CsharpNamespace.GetHashCode();
      if (CsharpClassName.Length != 0) hash ^= CsharpClassName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (CsharpPackageName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CsharpPackageName);
      }
      if (CsharpNamespace.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CsharpNamespace);
      }
      if (CsharpClassName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CsharpClassName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (CsharpPackageName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CsharpPackageName);
      }
      if (CsharpNamespace.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CsharpNamespace);
      }
      if (CsharpClassName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CsharpClassName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommonResource other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.CsharpPackageName.Length != 0) {
        CsharpPackageName = other.CsharpPackageName;
      }
      if (other.CsharpNamespace.Length != 0) {
        CsharpNamespace = other.CsharpNamespace;
      }
      if (other.CsharpClassName.Length != 0) {
        CsharpClassName = other.CsharpClassName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Type = input.ReadString();
            break;
          }
          case 18: {
            CsharpPackageName = input.ReadString();
            break;
          }
          case 26: {
            CsharpNamespace = input.ReadString();
            break;
          }
          case 34: {
            CsharpClassName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CommonResources : pb::IMessage<CommonResources> {
    private static readonly pb::MessageParser<CommonResources> _parser = new pb::MessageParser<CommonResources>(() => new CommonResources());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonResources> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.Generator.CommonResourcesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonResources() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonResources(CommonResources other) : this() {
      commonResources_ = other.commonResources_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonResources Clone() {
      return new CommonResources(this);
    }

    /// <summary>Field number for the "common_resources" field.</summary>
    public const int CommonResources_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Api.Generator.CommonResource> _repeated_commonResources_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Api.Generator.CommonResource.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.Generator.CommonResource> commonResources_ = new pbc::RepeatedField<global::Google.Api.Generator.CommonResource>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Api.Generator.CommonResource> CommonResources_ {
      get { return commonResources_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonResources);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonResources other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!commonResources_.Equals(other.commonResources_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= commonResources_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      commonResources_.WriteTo(output, _repeated_commonResources_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += commonResources_.CalculateSize(_repeated_commonResources_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommonResources other) {
      if (other == null) {
        return;
      }
      commonResources_.Add(other.commonResources_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            commonResources_.AddEntriesFrom(input, _repeated_commonResources_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code