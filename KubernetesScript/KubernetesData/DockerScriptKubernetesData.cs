using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace KubernetesScript.KubernetesData;

/// <summary>
/// Deployment enables declarative updates for Pods and ReplicaSets.
/// </summary>
public partial class Kubernetes
{
    /// <summary>
    /// APIVersion defines the versioned schema of this representation of an object. Servers
    /// should convert recognized schemas to the latest internal value, and may reject
    /// unrecognized values. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
    /// </summary>
    [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
    public ApiVersion? ApiVersion { get; set; }

    /// <summary>
    /// Kind is a string value representing the REST resource this object represents. Servers may
    /// infer this from the endpoint the client submits requests to. Cannot be updated. In
    /// CamelCase. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
    public DockerScriptKubernetesDataKind? Kind { get; set; }

    /// <summary>
    /// Standard object metadata.
    /// </summary>
    [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Specification of the desired behavior of the Deployment.
    /// </summary>
    [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiAppsV1DeploymentSpec Spec { get; set; }

    /// <summary>
    /// Most recently observed status of the Deployment.
    /// </summary>
    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiAppsV1DeploymentStatus Status { get; set; }
}

/// <summary>
/// Standard object metadata.
///
/// ObjectMeta is metadata that all persisted resources must have, which includes all objects
/// users must create.
///
/// Standard object's metadata. More info:
/// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1ObjectMeta
{
    /// <summary>
    /// Annotations is an unstructured key value map stored with a resource that may be set by
    /// external tools to store and retrieve arbitrary metadata. They are not queryable and
    /// should be preserved when modifying objects. More info:
    /// http://kubernetes.io/docs/user-guide/annotations
    /// </summary>
    [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, string> Annotations { get; set; }

    /// <summary>
    /// The name of the cluster which the object belongs to. This is used to distinguish
    /// resources with same name and namespace in different clusters. This field is not set
    /// anywhere right now and apiserver is going to ignore it if set in create or update request.
    /// </summary>
    [JsonProperty("clusterName", NullValueHandling = NullValueHandling.Ignore)]
    public string ClusterName { get; set; }

    /// <summary>
    /// CreationTimestamp is a timestamp representing the server time when this object was
    /// created. It is not guaranteed to be set in happens-before order across separate
    /// operations. Clients may not set this value. It is represented in RFC3339 form and is in
    /// UTC.
    ///
    /// Populated by the system. Read-only. Null for lists. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
    /// </summary>
    [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreationTimestamp { get; set; }

    /// <summary>
    /// Number of seconds allowed for this object to gracefully terminate before it will be
    /// removed from the system. Only set when deletionTimestamp is also set. May only be
    /// shortened. Read-only.
    /// </summary>
    [JsonProperty("deletionGracePeriodSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? DeletionGracePeriodSeconds { get; set; }

    /// <summary>
    /// DeletionTimestamp is RFC 3339 date and time at which this resource will be deleted. This
    /// field is set by the server when a graceful deletion is requested by the user, and is not
    /// directly settable by a client. The resource is expected to be deleted (no longer visible
    /// from resource lists, and not reachable by name) after the time in this field, once the
    /// finalizers list is empty. As long as the finalizers list contains items, deletion is
    /// blocked. Once the deletionTimestamp is set, this value may not be unset or be set further
    /// into the future, although it may be shortened or the resource may be deleted prior to
    /// this time. For example, a user may request that a pod is deleted in 30 seconds. The
    /// Kubelet will react by sending a graceful termination signal to the containers in the pod.
    /// After that 30 seconds, the Kubelet will send a hard termination signal (SIGKILL) to the
    /// container and after cleanup, remove the pod from the API. In the presence of network
    /// partitions, this object may still exist after this timestamp, until an administrator or
    /// automated process can determine the resource is fully terminated. If not set, graceful
    /// deletion of the object has not been requested.
    ///
    /// Populated by the system when a graceful deletion is requested. Read-only. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
    /// </summary>
    [JsonProperty("deletionTimestamp", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DeletionTimestamp { get; set; }

    /// <summary>
    /// Must be empty before the object is deleted from the registry. Each entry is an identifier
    /// for the responsible component that will remove the entry from the list. If the
    /// deletionTimestamp of the object is non-nil, entries in this list can only be removed.
    /// </summary>
    [JsonProperty("finalizers", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Finalizers { get; set; }

    /// <summary>
    /// GenerateName is an optional prefix, used by the server, to generate a unique name ONLY IF
    /// the Name field has not been provided. If this field is used, the name returned to the
    /// client will be different than the name passed. This value will also be combined with a
    /// unique suffix. The provided value has the same validation rules as the Name field, and
    /// may be truncated by the length of the suffix required to make the value unique on the
    /// server.
    ///
    /// If this field is specified and the generated name exists, the server will NOT return a
    /// 409 - instead, it will either return 201 Created or 500 with Reason ServerTimeout
    /// indicating a unique name could not be found in the time allotted, and the client should
    /// retry (optionally after the time indicated in the Retry-After header).
    ///
    /// Applied only if Name is not specified. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#idempotency
    /// </summary>
    [JsonProperty("generateName", NullValueHandling = NullValueHandling.Ignore)]
    public string GenerateName { get; set; }

    /// <summary>
    /// A sequence number representing a specific generation of the desired state. Populated by
    /// the system. Read-only.
    /// </summary>
    [JsonProperty("generation", NullValueHandling = NullValueHandling.Ignore)]
    public long? Generation { get; set; }

    /// <summary>
    /// An initializer is a controller which enforces some system invariant at object creation
    /// time. This field is a list of initializers that have not yet acted on this object. If nil
    /// or empty, this object has been completely initialized. Otherwise, the object is
    /// considered uninitialized and is hidden (in list/watch and get calls) from clients that
    /// haven't explicitly asked to observe uninitialized objects.
    ///
    /// When an object is created, the system will populate this list with the current set of
    /// initializers. Only privileged users may set or modify this list. Once it is empty, it may
    /// not be modified further by any user.
    ///
    /// DEPRECATED - initializers are an alpha field and will be removed in v1.15.
    /// </summary>
    [JsonProperty("initializers", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1Initializers Initializers { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize (scope and
    /// select) objects. May match selectors of replication controllers and services. More info:
    /// http://kubernetes.io/docs/user-guide/labels
    /// </summary>
    [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, string> Labels { get; set; }

    /// <summary>
    /// ManagedFields maps workflow-id and version to the set of fields that are managed by that
    /// workflow. This is mostly for internal housekeeping, and users typically shouldn't need to
    /// set or understand this field. A workflow can be the user's name, a controller's name, or
    /// the name of a specific apply path like "ci-cd". The set of fields is always in the
    /// version that the workflow used when modifying the object.
    ///
    /// This field is alpha and can be changed or removed without notice.
    /// </summary>
    [JsonProperty("managedFields", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1ManagedFieldsEntry[] ManagedFields { get; set; }

    /// <summary>
    /// Name must be unique within a namespace. Is required when creating resources, although
    /// some resources may allow a client to request the generation of an appropriate name
    /// automatically. Name is primarily intended for creation idempotence and configuration
    /// definition. Cannot be updated. More info:
    /// http://kubernetes.io/docs/user-guide/identifiers#names
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Namespace defines the space within each name must be unique. An empty namespace is
    /// equivalent to the "default" namespace, but "default" is the canonical representation. Not
    /// all objects are required to be scoped to a namespace - the value of this field for those
    /// objects will be empty.
    ///
    /// Must be a DNS_LABEL. Cannot be updated. More info:
    /// http://kubernetes.io/docs/user-guide/namespaces
    /// </summary>
    [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
    public string Namespace { get; set; }

    /// <summary>
    /// List of objects depended by this object. If ALL objects in the list have been deleted,
    /// this object will be garbage collected. If this object is managed by a controller, then an
    /// entry in this list will point to this controller, with the controller field set to true.
    /// There cannot be more than one managing controller.
    /// </summary>
    [JsonProperty("ownerReferences", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1OwnerReference[] OwnerReferences { get; set; }

    /// <summary>
    /// An opaque value that represents the internal version of this object that can be used by
    /// clients to determine when objects have changed. May be used for optimistic concurrency,
    /// change detection, and the watch operation on a resource or set of resources. Clients must
    /// treat these values as opaque and passed unmodified back to the server. They may only be
    /// valid for a particular resource or set of resources.
    ///
    /// Populated by the system. Read-only. Value must be treated as opaque by clients and . More
    /// info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
    /// </summary>
    [JsonProperty("resourceVersion", NullValueHandling = NullValueHandling.Ignore)]
    public string ResourceVersion { get; set; }

    /// <summary>
    /// SelfLink is a URL representing this object. Populated by the system. Read-only.
    /// </summary>
    [JsonProperty("selfLink", NullValueHandling = NullValueHandling.Ignore)]
    public string SelfLink { get; set; }

    /// <summary>
    /// UID is the unique in time and space value for this object. It is typically generated by
    /// the server on successful creation of a resource and is not allowed to change on PUT
    /// operations.
    ///
    /// Populated by the system. Read-only. More info:
    /// http://kubernetes.io/docs/user-guide/identifiers#uids
    /// </summary>
    [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
    public string Uid { get; set; }
}

/// <summary>
/// An initializer is a controller which enforces some system invariant at object creation
/// time. This field is a list of initializers that have not yet acted on this object. If nil
/// or empty, this object has been completely initialized. Otherwise, the object is
/// considered uninitialized and is hidden (in list/watch and get calls) from clients that
/// haven't explicitly asked to observe uninitialized objects.
///
/// When an object is created, the system will populate this list with the current set of
/// initializers. Only privileged users may set or modify this list. Once it is empty, it may
/// not be modified further by any user.
///
/// DEPRECATED - initializers are an alpha field and will be removed in v1.15.
///
/// Initializers tracks the progress of initialization.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1Initializers
{
    /// <summary>
    /// Pending is a list of initializers that must execute in order before this object is
    /// visible. When the last pending initializer is removed, and no failing result is set, the
    /// initializers struct will be set to nil and the object is considered as initialized and
    /// visible to all clients.
    /// </summary>
    [JsonProperty("pending")]
    public IoK8SApimachineryPkgApisMetaV1Initializer[] Pending { get; set; }

    /// <summary>
    /// If result is set with the Failure field, the object will be persisted to storage and then
    /// deleted, ensuring that other clients can observe the deletion.
    /// </summary>
    [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1Status Result { get; set; }
}

/// <summary>
/// Initializer is information about an initializer that has not yet completed.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1Initializer
{
    /// <summary>
    /// name of the process that is responsible for initializing this object.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
}

/// <summary>
/// If result is set with the Failure field, the object will be persisted to storage and then
/// deleted, ensuring that other clients can observe the deletion.
///
/// Status is a return value for calls that don't return other objects.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1Status
{
    /// <summary>
    /// APIVersion defines the versioned schema of this representation of an object. Servers
    /// should convert recognized schemas to the latest internal value, and may reject
    /// unrecognized values. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
    /// </summary>
    [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
    public string ApiVersion { get; set; }

    /// <summary>
    /// Suggested HTTP return code for this status, 0 if not set.
    /// </summary>
    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    public long? Code { get; set; }

    /// <summary>
    /// Extended data associated with the reason.  Each reason may define its own extended
    /// details. This field is optional and the data returned is not guaranteed to conform to any
    /// schema except that defined by the reason type.
    /// </summary>
    [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1StatusDetails Details { get; set; }

    /// <summary>
    /// Kind is a string value representing the REST resource this object represents. Servers may
    /// infer this from the endpoint the client submits requests to. Cannot be updated. In
    /// CamelCase. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
    public ResultKind? Kind { get; set; }

    /// <summary>
    /// A human-readable description of the status of this operation.
    /// </summary>
    [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
    public string Message { get; set; }

    /// <summary>
    /// Standard list metadata. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1ListMeta Metadata { get; set; }

    /// <summary>
    /// A machine-readable description of why this operation is in the "Failure" status. If this
    /// value is empty there is no information available. A Reason clarifies an HTTP status code
    /// but does not override it.
    /// </summary>
    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string Reason { get; set; }

    /// <summary>
    /// Status of the operation. One of: "Success" or "Failure". More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
    /// </summary>
    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public string Status { get; set; }
}

/// <summary>
/// Extended data associated with the reason.  Each reason may define its own extended
/// details. This field is optional and the data returned is not guaranteed to conform to any
/// schema except that defined by the reason type.
///
/// StatusDetails is a set of additional properties that MAY be set by the server to provide
/// additional information about a response. The Reason field of a Status object defines what
/// attributes will be set. Clients must ignore fields that do not match the defined type of
/// each attribute, and should assume that any attribute may be empty, invalid, or under
/// defined.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1StatusDetails
{
    /// <summary>
    /// The Causes array includes more details associated with the StatusReason failure. Not all
    /// StatusReasons may provide detailed causes.
    /// </summary>
    [JsonProperty("causes", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1StatusCause[] Causes { get; set; }

    /// <summary>
    /// The group attribute of the resource associated with the status StatusReason.
    /// </summary>
    [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
    public string Group { get; set; }

    /// <summary>
    /// The kind attribute of the resource associated with the status StatusReason. On some
    /// operations may differ from the requested resource Kind. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
    public string Kind { get; set; }

    /// <summary>
    /// The name attribute of the resource associated with the status StatusReason (when there is
    /// a single name which can be described).
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// If specified, the time in seconds before the operation should be retried. Some errors may
    /// indicate the client must take an alternate action - for those errors this field may
    /// indicate how long to wait before taking the alternate action.
    /// </summary>
    [JsonProperty("retryAfterSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? RetryAfterSeconds { get; set; }

    /// <summary>
    /// UID of the resource. (when there is a single resource which can be described). More info:
    /// http://kubernetes.io/docs/user-guide/identifiers#uids
    /// </summary>
    [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
    public string Uid { get; set; }
}

/// <summary>
/// StatusCause provides more information about an api.Status failure, including cases when
/// multiple errors are encountered.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1StatusCause
{
    /// <summary>
    /// The field of the resource that has caused this error, as named by its JSON serialization.
    /// May include dot and postfix notation for nested attributes. Arrays are zero-indexed.
    /// Fields may appear more than once in an array of causes due to fields having multiple
    /// errors. Optional.
    ///
    /// Examples:
    /// "name" - the field "name" on the current resource
    /// "items[0].name" - the field "name" on the first array entry in "items"
    /// </summary>
    [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
    public string Field { get; set; }

    /// <summary>
    /// A human-readable description of the cause of the error.  This field may be presented
    /// as-is to a reader.
    /// </summary>
    [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
    public string Message { get; set; }

    /// <summary>
    /// A machine-readable description of the cause of the error. If this value is empty there is
    /// no information available.
    /// </summary>
    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string Reason { get; set; }
}

/// <summary>
/// Standard list metadata. More info:
/// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
///
/// ListMeta describes metadata that synthetic resources must have, including lists and
/// various status objects. A resource may have only one of {ObjectMeta, ListMeta}.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1ListMeta
{
    /// <summary>
    /// continue may be set if the user set a limit on the number of items returned, and
    /// indicates that the server has more data available. The value is opaque and may be used to
    /// issue another request to the endpoint that served this list to retrieve the next set of
    /// available objects. Continuing a consistent list may not be possible if the server
    /// configuration has changed or more than a few minutes have passed. The resourceVersion
    /// field returned when using this continue value will be identical to the value in the first
    /// response, unless you have received this token from an error message.
    /// </summary>
    [JsonProperty("continue", NullValueHandling = NullValueHandling.Ignore)]
    public string Continue { get; set; }

    /// <summary>
    /// String that identifies the server's internal version of this object that can be used by
    /// clients to determine when objects have changed. Value must be treated as opaque by
    /// clients and passed unmodified back to the server. Populated by the system. Read-only.
    /// More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
    /// </summary>
    [JsonProperty("resourceVersion", NullValueHandling = NullValueHandling.Ignore)]
    public string ResourceVersion { get; set; }

    /// <summary>
    /// selfLink is a URL representing this object. Populated by the system. Read-only.
    /// </summary>
    [JsonProperty("selfLink", NullValueHandling = NullValueHandling.Ignore)]
    public string SelfLink { get; set; }
}

/// <summary>
/// ManagedFieldsEntry is a workflow-id, a FieldSet and the group version of the resource
/// that the fieldset applies to.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1ManagedFieldsEntry
{
    /// <summary>
    /// APIVersion defines the version of this resource that this field set applies to. The
    /// format is "group/version" just like the top-level APIVersion field. It is necessary to
    /// track the version of a field set because it cannot be automatically converted.
    /// </summary>
    [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
    public string ApiVersion { get; set; }

    /// <summary>
    /// Fields identifies a set of fields.
    /// </summary>
    [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, object> Fields { get; set; }

    /// <summary>
    /// Manager is an identifier of the workflow managing these fields.
    /// </summary>
    [JsonProperty("manager", NullValueHandling = NullValueHandling.Ignore)]
    public string Manager { get; set; }

    /// <summary>
    /// Operation is the type of operation which lead to this ManagedFieldsEntry being created.
    /// The only valid values for this field are 'Apply' and 'Update'.
    /// </summary>
    [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
    public string Operation { get; set; }

    /// <summary>
    /// Time is timestamp of when these fields were set. It should always be empty if Operation
    /// is 'Apply'
    /// </summary>
    [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Time { get; set; }
}

/// <summary>
/// OwnerReference contains enough information to let you identify an owning object. An
/// owning object must be in the same namespace as the dependent, or be cluster-scoped, so
/// there is no namespace field.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1OwnerReference
{
    /// <summary>
    /// API version of the referent.
    /// </summary>
    [JsonProperty("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// If true, AND if the owner has the "foregroundDeletion" finalizer, then the owner cannot
    /// be deleted from the key-value store until this reference is removed. Defaults to false.
    /// To set this field, a user needs "delete" permission of the owner, otherwise 422
    /// (Unprocessable Entity) will be returned.
    /// </summary>
    [JsonProperty("blockOwnerDeletion", NullValueHandling = NullValueHandling.Ignore)]
    public bool? BlockOwnerDeletion { get; set; }

    /// <summary>
    /// If true, this reference points to the managing controller.
    /// </summary>
    [JsonProperty("controller", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Controller { get; set; }

    /// <summary>
    /// Kind of the referent. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    [JsonProperty("kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Name of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#names
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// UID of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#uids
    /// </summary>
    [JsonProperty("uid")]
    public string Uid { get; set; }
}

/// <summary>
/// Specification of the desired behavior of the Deployment.
///
/// DeploymentSpec is the specification of the desired behavior of the Deployment.
/// </summary>
public partial class IoK8SApiAppsV1DeploymentSpec
{
    /// <summary>
    /// Minimum number of seconds for which a newly created pod should be ready without any of
    /// its container crashing, for it to be considered available. Defaults to 0 (pod will be
    /// considered available as soon as it is ready)
    /// </summary>
    [JsonProperty("minReadySeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? MinReadySeconds { get; set; }

    /// <summary>
    /// Indicates that the deployment is paused.
    /// </summary>
    [JsonProperty("paused", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Paused { get; set; }

    /// <summary>
    /// The maximum time in seconds for a deployment to make progress before it is considered to
    /// be failed. The deployment controller will continue to process failed deployments and a
    /// condition with a ProgressDeadlineExceeded reason will be surfaced in the deployment
    /// status. Note that progress will not be estimated during the time a deployment is paused.
    /// Defaults to 600s.
    /// </summary>
    [JsonProperty("progressDeadlineSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? ProgressDeadlineSeconds { get; set; }

    /// <summary>
    /// Number of desired pods. This is a pointer to distinguish between explicit zero and not
    /// specified. Defaults to 1.
    /// </summary>
    [JsonProperty("replicas", NullValueHandling = NullValueHandling.Ignore)]
    public long? Replicas { get; set; }

    /// <summary>
    /// The number of old ReplicaSets to retain to allow rollback. This is a pointer to
    /// distinguish between explicit zero and not specified. Defaults to 10.
    /// </summary>
    [JsonProperty("revisionHistoryLimit", NullValueHandling = NullValueHandling.Ignore)]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary>
    /// Label selector for pods. Existing ReplicaSets whose pods are selected by this will be the
    /// ones affected by this deployment. It must match the pod template's labels.
    /// </summary>
    [JsonProperty("selector")]
    public IoK8SApimachineryPkgApisMetaV1LabelSelector Selector { get; set; }

    /// <summary>
    /// The deployment strategy to use to replace existing pods with new ones.
    /// </summary>
    [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiAppsV1DeploymentStrategy Strategy { get; set; }

    /// <summary>
    /// Template describes the pods that will be created.
    /// </summary>
    [JsonProperty("template")]
    public IoK8SApiCoreV1PodTemplateSpec Template { get; set; }
}

/// <summary>
/// Label selector for pods. Existing ReplicaSets whose pods are selected by this will be the
/// ones affected by this deployment. It must match the pod template's labels.
///
/// A label selector is a label query over a set of resources. The result of matchLabels and
/// matchExpressions are ANDed. An empty label selector matches all objects. A null label
/// selector matches no objects.
///
/// A label query over a set of resources, in this case pods.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1LabelSelector
{
    /// <summary>
    /// matchExpressions is a list of label selector requirements. The requirements are ANDed.
    /// </summary>
    [JsonProperty("matchExpressions", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1LabelSelectorRequirement[] MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is
    /// equivalent to an element of matchExpressions, whose key field is "key", the operator is
    /// "In", and the values array contains only "value". The requirements are ANDed.
    /// </summary>
    [JsonProperty("matchLabels", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, string> MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
public partial class IoK8SApimachineryPkgApisMetaV1LabelSelectorRequirement
{
    /// <summary>
    /// key is the label key that the selector applies to.
    /// </summary>
    [JsonProperty("key")]
    public string Key { get; set; }

    /// <summary>
    /// operator represents a key's relationship to a set of values. Valid operators are In,
    /// NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonProperty("operator")]
    public string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn, the values array
    /// must be non-empty. If the operator is Exists or DoesNotExist, the values array must be
    /// empty. This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Values { get; set; }
}

/// <summary>
/// The deployment strategy to use to replace existing pods with new ones.
///
/// DeploymentStrategy describes how to replace existing pods with new ones.
/// </summary>
public partial class IoK8SApiAppsV1DeploymentStrategy
{
    /// <summary>
    /// Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.
    /// </summary>
    [JsonProperty("rollingUpdate", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiAppsV1RollingUpdateDeployment RollingUpdate { get; set; }

    /// <summary>
    /// Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }
}

/// <summary>
/// Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.
///
/// Spec to control the desired behavior of rolling update.
/// </summary>
public partial class IoK8SApiAppsV1RollingUpdateDeployment
{
    /// <summary>
    /// The maximum number of pods that can be scheduled above the desired number of pods. Value
    /// can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). This can not
    /// be 0 if MaxUnavailable is 0. Absolute number is calculated from percentage by rounding
    /// up. Defaults to 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled
    /// up immediately when the rolling update starts, such that the total number of old and new
    /// pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet
    /// can be scaled up further, ensuring that total number of pods running at any time during
    /// the update is at most 130% of desired pods.
    /// </summary>
    [JsonProperty("maxSurge", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgUtilIntstrIntOrString? MaxSurge { get; set; }

    /// <summary>
    /// The maximum number of pods that can be unavailable during the update. Value can be an
    /// absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is
    /// calculated from percentage by rounding down. This can not be 0 if MaxSurge is 0. Defaults
    /// to 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of
    /// desired pods immediately when the rolling update starts. Once new pods are ready, old
    /// ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet,
    /// ensuring that the total number of pods available at all times during the update is at
    /// least 70% of desired pods.
    /// </summary>
    [JsonProperty("maxUnavailable", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgUtilIntstrIntOrString? MaxUnavailable { get; set; }
}

/// <summary>
/// Template describes the pods that will be created.
///
/// PodTemplateSpec describes the data a pod should have when created from a template
/// </summary>
public partial class IoK8SApiCoreV1PodTemplateSpec
{
    /// <summary>
    /// Standard object's metadata. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
    /// </summary>
    [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Specification of the desired behavior of the pod. More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
    /// </summary>
    [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PodSpec Spec { get; set; }
}

/// <summary>
/// Specification of the desired behavior of the pod. More info:
/// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
///
/// PodSpec is a description of a pod.
/// </summary>
public partial class IoK8SApiCoreV1PodSpec
{
    /// <summary>
    /// Optional duration in seconds the pod may be active on the node relative to StartTime
    /// before the system will actively try to mark it failed and kill associated containers.
    /// Value must be a positive integer.
    /// </summary>
    [JsonProperty("activeDeadlineSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary>
    /// If specified, the pod's scheduling constraints
    /// </summary>
    [JsonProperty("affinity", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Affinity Affinity { get; set; }

    /// <summary>
    /// AutomountServiceAccountToken indicates whether a service account token should be
    /// automatically mounted.
    /// </summary>
    [JsonProperty("automountServiceAccountToken", NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary>
    /// List of containers belonging to the pod. Containers cannot currently be added or removed.
    /// There must be at least one container in a Pod. Cannot be updated.
    /// </summary>
    [JsonProperty("containers")]
    public IoK8SApiCoreV1Container[] Containers { get; set; }

    /// <summary>
    /// Specifies the DNS parameters of a pod. Parameters specified here will be merged to the
    /// generated DNS configuration based on DNSPolicy.
    /// </summary>
    [JsonProperty("dnsConfig", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PodDnsConfig DnsConfig { get; set; }

    /// <summary>
    /// Set DNS policy for the pod. Defaults to "ClusterFirst". Valid values are
    /// 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in
    /// DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set
    /// along with hostNetwork, you have to specify DNS policy explicitly to
    /// 'ClusterFirstWithHostNet'.
    /// </summary>
    [JsonProperty("dnsPolicy", NullValueHandling = NullValueHandling.Ignore)]
    public string DnsPolicy { get; set; }

    /// <summary>
    /// EnableServiceLinks indicates whether information about services should be injected into
    /// pod's environment variables, matching the syntax of Docker links. Optional: Defaults to
    /// true.
    /// </summary>
    [JsonProperty("enableServiceLinks", NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>
    /// HostAliases is an optional list of hosts and IPs that will be injected into the pod's
    /// hosts file if specified. This is only valid for non-hostNetwork pods.
    /// </summary>
    [JsonProperty("hostAliases", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1HostAlias[] HostAliases { get; set; }

    /// <summary>
    /// Use the host's ipc namespace. Optional: Default to false.
    /// </summary>
    [JsonProperty("hostIPC", NullValueHandling = NullValueHandling.Ignore)]
    public bool? HostIpc { get; set; }

    /// <summary>
    /// Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a
    /// system-defined value.
    /// </summary>
    [JsonProperty("hostname", NullValueHandling = NullValueHandling.Ignore)]
    public string Hostname { get; set; }

    /// <summary>
    /// Host networking requested for this pod. Use the host's network namespace. If this option
    /// is set, the ports that will be used must be specified. Default to false.
    /// </summary>
    [JsonProperty("hostNetwork", NullValueHandling = NullValueHandling.Ignore)]
    public bool? HostNetwork { get; set; }

    /// <summary>
    /// Use the host's pid namespace. Optional: Default to false.
    /// </summary>
    [JsonProperty("hostPID", NullValueHandling = NullValueHandling.Ignore)]
    public bool? HostPid { get; set; }

    /// <summary>
    /// ImagePullSecrets is an optional list of references to secrets in the same namespace to
    /// use for pulling any of the images used by this PodSpec. If specified, these secrets will
    /// be passed to individual puller implementations for them to use. For example, in the case
    /// of docker, only DockerConfig type secrets are honored. More info:
    /// https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
    /// </summary>
    [JsonProperty("imagePullSecrets", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1LocalObjectReference[] ImagePullSecrets { get; set; }

    /// <summary>
    /// List of initialization containers belonging to the pod. Init containers are executed in
    /// order prior to containers being started. If any init container fails, the pod is
    /// considered to have failed and is handled according to its restartPolicy. The name for an
    /// init container or normal container must be unique among all containers. Init containers
    /// may not have Lifecycle actions, Readiness probes, or Liveness probes. The
    /// resourceRequirements of an init container are taken into account during scheduling by
    /// finding the highest request/limit for each resource type, and then using the max of of
    /// that value or the sum of the normal containers. Limits are applied to init containers in
    /// a similar fashion. Init containers cannot currently be added or removed. Cannot be
    /// updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/
    /// </summary>
    [JsonProperty("initContainers", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Container[] InitContainers { get; set; }

    /// <summary>
    /// NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the
    /// scheduler simply schedules this pod onto that node, assuming that it fits resource
    /// requirements.
    /// </summary>
    [JsonProperty("nodeName", NullValueHandling = NullValueHandling.Ignore)]
    public string NodeName { get; set; }

    /// <summary>
    /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector
    /// which must match a node's labels for the pod to be scheduled on that node. More info:
    /// https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
    /// </summary>
    [JsonProperty("nodeSelector", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, string> NodeSelector { get; set; }

    /// <summary>
    /// The priority value. Various system components use this field to find the priority of the
    /// pod. When Priority Admission Controller is enabled, it prevents users from setting this
    /// field. The admission controller populates this field from PriorityClassName. The higher
    /// the value, the higher the priority.
    /// </summary>
    [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
    public long? Priority { get; set; }

    /// <summary>
    /// If specified, indicates the pod's priority. "system-node-critical" and
    /// "system-cluster-critical" are two special keywords which indicate the highest priorities
    /// with the former being the highest priority. Any other name must be defined by creating a
    /// PriorityClass object with that name. If not specified, the pod priority will be default
    /// or zero if there is no default.
    /// </summary>
    [JsonProperty("priorityClassName", NullValueHandling = NullValueHandling.Ignore)]
    public string PriorityClassName { get; set; }

    /// <summary>
    /// If specified, all readiness gates will be evaluated for pod readiness. A pod is ready
    /// when all its containers are ready AND all conditions specified in the readiness gates
    /// have status equal to "True" More info:
    /// https://git.k8s.io/enhancements/keps/sig-network/0007-pod-ready%2B%2B.md
    /// </summary>
    [JsonProperty("readinessGates", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PodReadinessGate[] ReadinessGates { get; set; }

    /// <summary>
    /// Restart policy for all containers within the pod. One of Always, OnFailure, Never.
    /// Default to Always. More info:
    /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
    /// </summary>
    [JsonProperty("restartPolicy", NullValueHandling = NullValueHandling.Ignore)]
    public string RestartPolicy { get; set; }

    /// <summary>
    /// RuntimeClassName refers to a RuntimeClass object in the node.k8s.io group, which should
    /// be used to run this pod.  If no RuntimeClass resource matches the named class, the pod
    /// will not be run. If unset or empty, the "legacy" RuntimeClass will be used, which is an
    /// implicit class with an empty definition that uses the default runtime handler. More info:
    /// https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md This is an alpha feature
    /// and may change in the future.
    /// </summary>
    [JsonProperty("runtimeClassName", NullValueHandling = NullValueHandling.Ignore)]
    public string RuntimeClassName { get; set; }

    /// <summary>
    /// If specified, the pod will be dispatched by specified scheduler. If not specified, the
    /// pod will be dispatched by default scheduler.
    /// </summary>
    [JsonProperty("schedulerName", NullValueHandling = NullValueHandling.Ignore)]
    public string SchedulerName { get; set; }

    /// <summary>
    /// SecurityContext holds pod-level security attributes and common container settings.
    /// Optional: Defaults to empty.  See type description for default values of each field.
    /// </summary>
    [JsonProperty("securityContext", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PodSecurityContext SecurityContext { get; set; }

    /// <summary>
    /// DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use
    /// serviceAccountName instead.
    /// </summary>
    [JsonProperty("serviceAccount", NullValueHandling = NullValueHandling.Ignore)]
    public string ServiceAccount { get; set; }

    /// <summary>
    /// ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info:
    /// https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
    /// </summary>
    [JsonProperty("serviceAccountName", NullValueHandling = NullValueHandling.Ignore)]
    public string ServiceAccountName { get; set; }

    /// <summary>
    /// Share a single process namespace between all of the containers in a pod. When this is set
    /// containers will be able to view and signal processes from other containers in the same
    /// pod, and the first process in each container will not be assigned PID 1. HostPID and
    /// ShareProcessNamespace cannot both be set. Optional: Default to false. This field is
    /// beta-level and may be disabled with the PodShareProcessNamespace feature.
    /// </summary>
    [JsonProperty("shareProcessNamespace", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShareProcessNamespace { get; set; }

    /// <summary>
    /// If specified, the fully qualified Pod hostname will be "<hostname>.<subdomain>.<pod
    /// namespace>.svc.<cluster domain>". If not specified, the pod will not have a domainname at
    /// all.
    /// </summary>
    [JsonProperty("subdomain", NullValueHandling = NullValueHandling.Ignore)]
    public string Subdomain { get; set; }

    /// <summary>
    /// Optional duration in seconds the pod needs to terminate gracefully. May be decreased in
    /// delete request. Value must be non-negative integer. The value zero indicates delete
    /// immediately. If this value is nil, the default grace period will be used instead. The
    /// grace period is the duration in seconds after the processes running in the pod are sent a
    /// termination signal and the time when the processes are forcibly halted with a kill
    /// signal. Set this value longer than the expected cleanup time for your process. Defaults
    /// to 30 seconds.
    /// </summary>
    [JsonProperty("terminationGracePeriodSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// If specified, the pod's tolerations.
    /// </summary>
    [JsonProperty("tolerations", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Toleration[] Tolerations { get; set; }

    /// <summary>
    /// List of volumes that can be mounted by containers belonging to the pod. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes
    /// </summary>
    [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Volume[] Volumes { get; set; }
}

/// <summary>
/// If specified, the pod's scheduling constraints
///
/// Affinity is a group of affinity scheduling rules.
/// </summary>
public partial class IoK8SApiCoreV1Affinity
{
    /// <summary>
    /// Describes node affinity scheduling rules for the pod.
    /// </summary>
    [JsonProperty("nodeAffinity", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1NodeAffinity NodeAffinity { get; set; }

    /// <summary>
    /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone,
    /// etc. as some other pod(s)).
    /// </summary>
    [JsonProperty("podAffinity", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PodAffinity PodAffinity { get; set; }

    /// <summary>
    /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same
    /// node, zone, etc. as some other pod(s)).
    /// </summary>
    [JsonProperty("podAntiAffinity", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PodAntiAffinity PodAntiAffinity { get; set; }
}

/// <summary>
/// Describes node affinity scheduling rules for the pod.
///
/// Node affinity is a group of node affinity scheduling rules.
/// </summary>
public partial class IoK8SApiCoreV1NodeAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions
    /// specified by this field, but it may choose a node that violates one or more of the
    /// expressions. The node that is most preferred is the one with the greatest sum of weights,
    /// i.e. for each node that meets all of the scheduling requirements (resource request,
    /// requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through
    /// the elements of this field and adding "weight" to the sum if the node matches the
    /// corresponding matchExpressions; the node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonProperty("preferredDuringSchedulingIgnoredDuringExecution", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PreferredSchedulingTerm[] PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at scheduling time, the
    /// pod will not be scheduled onto the node. If the affinity requirements specified by this
    /// field cease to be met at some point during pod execution (e.g. due to an update), the
    /// system may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonProperty("requiredDuringSchedulingIgnoredDuringExecution", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1NodeSelector RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's
/// a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
public partial class IoK8SApiCoreV1PreferredSchedulingTerm
{
    /// <summary>
    /// A node selector term, associated with the corresponding weight.
    /// </summary>
    [JsonProperty("preference")]
    public IoK8SApiCoreV1NodeSelectorTerm Preference { get; set; }

    /// <summary>
    /// Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
    /// </summary>
    [JsonProperty("weight")]
    public long Weight { get; set; }
}

/// <summary>
/// A node selector term, associated with the corresponding weight.
///
/// A null or empty node selector term matches no objects. The requirements of them are
/// ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
/// </summary>
public partial class IoK8SApiCoreV1NodeSelectorTerm
{
    /// <summary>
    /// A list of node selector requirements by node's labels.
    /// </summary>
    [JsonProperty("matchExpressions", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1NodeSelectorRequirement[] MatchExpressions { get; set; }

    /// <summary>
    /// A list of node selector requirements by node's fields.
    /// </summary>
    [JsonProperty("matchFields", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1NodeSelectorRequirement[] MatchFields { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
public partial class IoK8SApiCoreV1NodeSelectorRequirement
{
    /// <summary>
    /// The label key that the selector applies to.
    /// </summary>
    [JsonProperty("key")]
    public string Key { get; set; }

    /// <summary>
    /// Represents a key's relationship to a set of values. Valid operators are In, NotIn,
    /// Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonProperty("operator")]
    public string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn, the values array must be
    /// non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If
    /// the operator is Gt or Lt, the values array must have a single element, which will be
    /// interpreted as an integer. This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Values { get; set; }
}

/// <summary>
/// If the affinity requirements specified by this field are not met at scheduling time, the
/// pod will not be scheduled onto the node. If the affinity requirements specified by this
/// field cease to be met at some point during pod execution (e.g. due to an update), the
/// system may or may not try to eventually evict the pod from its node.
///
/// A node selector represents the union of the results of one or more label queries over a
/// set of nodes; that is, it represents the OR of the selectors represented by the node
/// selector terms.
/// </summary>
public partial class IoK8SApiCoreV1NodeSelector
{
    /// <summary>
    /// Required. A list of node selector terms. The terms are ORed.
    /// </summary>
    [JsonProperty("nodeSelectorTerms")]
    public IoK8SApiCoreV1NodeSelectorTerm[] NodeSelectorTerms { get; set; }
}

/// <summary>
/// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone,
/// etc. as some other pod(s)).
///
/// Pod affinity is a group of inter pod affinity scheduling rules.
/// </summary>
public partial class IoK8SApiCoreV1PodAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions
    /// specified by this field, but it may choose a node that violates one or more of the
    /// expressions. The node that is most preferred is the one with the greatest sum of weights,
    /// i.e. for each node that meets all of the scheduling requirements (resource request,
    /// requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through
    /// the elements of this field and adding "weight" to the sum if the node has pods which
    /// matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most
    /// preferred.
    /// </summary>
    [JsonProperty("preferredDuringSchedulingIgnoredDuringExecution", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1WeightedPodAffinityTerm[] PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at scheduling time, the
    /// pod will not be scheduled onto the node. If the affinity requirements specified by this
    /// field cease to be met at some point during pod execution (e.g. due to a pod label
    /// update), the system may or may not try to eventually evict the pod from its node. When
    /// there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are
    /// intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonProperty("requiredDuringSchedulingIgnoredDuringExecution", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PodAffinityTerm[] RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to
/// find the most preferred node(s)
/// </summary>
public partial class IoK8SApiCoreV1WeightedPodAffinityTerm
{
    /// <summary>
    /// Required. A pod affinity term, associated with the corresponding weight.
    /// </summary>
    [JsonProperty("podAffinityTerm")]
    public IoK8SApiCoreV1PodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm, in the range 1-100.
    /// </summary>
    [JsonProperty("weight")]
    public long Weight { get; set; }
}

/// <summary>
/// Required. A pod affinity term, associated with the corresponding weight.
///
/// Defines a set of pods (namely those matching the labelSelector relative to the given
/// namespace(s)) that this pod should be co-located (affinity) or not co-located
/// (anti-affinity) with, where co-located is defined as running on a node whose value of the
/// label with key <topologyKey> matches that of any node on which a pod of the set of pods
/// is running
/// </summary>
public partial class IoK8SApiCoreV1PodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// </summary>
    [JsonProperty("labelSelector", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApisMetaV1LabelSelector LabelSelector { get; set; }

    /// <summary>
    /// namespaces specifies which namespaces the labelSelector applies to (matches against);
    /// null or empty list means "this pod's namespace"
    /// </summary>
    [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods
    /// matching the labelSelector in the specified namespaces, where co-located is defined as
    /// running on a node whose value of the label with key topologyKey matches that of any node
    /// on which any of the selected pods is running. Empty topologyKey is not allowed.
    /// </summary>
    [JsonProperty("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>
/// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same
/// node, zone, etc. as some other pod(s)).
///
/// Pod anti affinity is a group of inter pod anti affinity scheduling rules.
/// </summary>
public partial class IoK8SApiCoreV1PodAntiAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity
    /// expressions specified by this field, but it may choose a node that violates one or more
    /// of the expressions. The node that is most preferred is the one with the greatest sum of
    /// weights, i.e. for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by
    /// iterating through the elements of this field and adding "weight" to the sum if the node
    /// has pods which matches the corresponding podAffinityTerm; the node(s) with the highest
    /// sum are the most preferred.
    /// </summary>
    [JsonProperty("preferredDuringSchedulingIgnoredDuringExecution", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1WeightedPodAffinityTerm[] PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the anti-affinity requirements specified by this field are not met at scheduling time,
    /// the pod will not be scheduled onto the node. If the anti-affinity requirements specified
    /// by this field cease to be met at some point during pod execution (e.g. due to a pod label
    /// update), the system may or may not try to eventually evict the pod from its node. When
    /// there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are
    /// intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonProperty("requiredDuringSchedulingIgnoredDuringExecution", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PodAffinityTerm[] RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A single application container that you want to run within a pod.
/// </summary>
public partial class IoK8SApiCoreV1Container
{
    /// <summary>
    /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided.
    /// Variable references $(VAR_NAME) are expanded using the container's environment. If a
    /// variable cannot be resolved, the reference in the input string will be unchanged. The
    /// $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references
    /// will never be expanded, regardless of whether the variable exists or not. Cannot be
    /// updated. More info:
    /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
    /// </summary>
    [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Args { get; set; }

    /// <summary>
    /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if
    /// this is not provided. Variable references $(VAR_NAME) are expanded using the container's
    /// environment. If a variable cannot be resolved, the reference in the input string will be
    /// unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME).
    /// Escaped references will never be expanded, regardless of whether the variable exists or
    /// not. Cannot be updated. More info:
    /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
    /// </summary>
    [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Command { get; set; }

    /// <summary>
    /// List of environment variables to set in the container. Cannot be updated.
    /// </summary>
    [JsonProperty("env", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1EnvVar[] Env { get; set; }

    /// <summary>
    /// List of sources to populate environment variables in the container. The keys defined
    /// within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event
    /// when the container is starting. When a key exists in multiple sources, the value
    /// associated with the last source will take precedence. Values defined by an Env with a
    /// duplicate key will take precedence. Cannot be updated.
    /// </summary>
    [JsonProperty("envFrom", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1EnvFromSource[] EnvFrom { get; set; }

    /// <summary>
    /// Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images This
    /// field is optional to allow higher level config management to default or override
    /// container images in workload controllers like Deployments and StatefulSets.
    /// </summary>
    [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
    public string Image { get; set; }

    /// <summary>
    /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag
    /// is specified, or IfNotPresent otherwise. Cannot be updated. More info:
    /// https://kubernetes.io/docs/concepts/containers/images#updating-images
    /// </summary>
    [JsonProperty("imagePullPolicy", NullValueHandling = NullValueHandling.Ignore)]
    public string ImagePullPolicy { get; set; }

    /// <summary>
    /// Actions that the management system should take in response to container lifecycle events.
    /// Cannot be updated.
    /// </summary>
    [JsonProperty("lifecycle", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Lifecycle Lifecycle { get; set; }

    /// <summary>
    /// Periodic probe of container liveness. Container will be restarted if the probe fails.
    /// Cannot be updated. More info:
    /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    [JsonProperty("livenessProbe", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Probe LivenessProbe { get; set; }

    /// <summary>
    /// Name of the container specified as a DNS_LABEL. Each container in a pod must have a
    /// unique name (DNS_LABEL). Cannot be updated.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// List of ports to expose from the container. Exposing a port here gives the system
    /// additional information about the network connections a container uses, but is primarily
    /// informational. Not specifying a port here DOES NOT prevent that port from being exposed.
    /// Any port which is listening on the default "0.0.0.0" address inside a container will be
    /// accessible from the network. Cannot be updated.
    /// </summary>
    [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ContainerPort[] Ports { get; set; }

    /// <summary>
    /// Periodic probe of container service readiness. Container will be removed from service
    /// endpoints if the probe fails. Cannot be updated. More info:
    /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    [JsonProperty("readinessProbe", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Probe ReadinessProbe { get; set; }

    /// <summary>
    /// Compute Resources required by this container. Cannot be updated. More info:
    /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
    /// </summary>
    [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ResourceRequirements Resources { get; set; }

    /// <summary>
    /// Security options the pod should run with. More info:
    /// https://kubernetes.io/docs/concepts/policy/security-context/ More info:
    /// https://kubernetes.io/docs/tasks/configure-pod-container/security-context/
    /// </summary>
    [JsonProperty("securityContext", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1SecurityContext SecurityContext { get; set; }

    /// <summary>
    /// Whether this container should allocate a buffer for stdin in the container runtime. If
    /// this is not set, reads from stdin in the container will always result in EOF. Default is
    /// false.
    /// </summary>
    [JsonProperty("stdin", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Stdin { get; set; }

    /// <summary>
    /// Whether the container runtime should close the stdin channel after it has been opened by
    /// a single attach. When stdin is true the stdin stream will remain open across multiple
    /// attach sessions. If stdinOnce is set to true, stdin is opened on container start, is
    /// empty until the first client attaches to stdin, and then remains open and accepts data
    /// until the client disconnects, at which time stdin is closed and remains closed until the
    /// container is restarted. If this flag is false, a container processes that reads from
    /// stdin will never receive an EOF. Default is false
    /// </summary>
    [JsonProperty("stdinOnce", NullValueHandling = NullValueHandling.Ignore)]
    public bool? StdinOnce { get; set; }

    /// <summary>
    /// Optional: Path at which the file to which the container's termination message will be
    /// written is mounted into the container's filesystem. Message written is intended to be
    /// brief final status, such as an assertion failure message. Will be truncated by the node
    /// if greater than 4096 bytes. The total message length across all containers will be
    /// limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
    /// </summary>
    [JsonProperty("terminationMessagePath", NullValueHandling = NullValueHandling.Ignore)]
    public string TerminationMessagePath { get; set; }

    /// <summary>
    /// Indicate how the termination message should be populated. File will use the contents of
    /// terminationMessagePath to populate the container status message on both success and
    /// failure. FallbackToLogsOnError will use the last chunk of container log output if the
    /// termination message file is empty and the container exited with an error. The log output
    /// is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be
    /// updated.
    /// </summary>
    [JsonProperty("terminationMessagePolicy", NullValueHandling = NullValueHandling.Ignore)]
    public string TerminationMessagePolicy { get; set; }

    /// <summary>
    /// Whether this container should allocate a TTY for itself, also requires 'stdin' to be
    /// true. Default is false.
    /// </summary>
    [JsonProperty("tty", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Tty { get; set; }

    /// <summary>
    /// volumeDevices is the list of block devices to be used by the container. This is a beta
    /// feature.
    /// </summary>
    [JsonProperty("volumeDevices", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1VolumeDevice[] VolumeDevices { get; set; }

    /// <summary>
    /// Pod volumes to mount into the container's filesystem. Cannot be updated.
    /// </summary>
    [JsonProperty("volumeMounts", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1VolumeMount[] VolumeMounts { get; set; }

    /// <summary>
    /// Container's working directory. If not specified, the container runtime's default will be
    /// used, which might be configured in the container image. Cannot be updated.
    /// </summary>
    [JsonProperty("workingDir", NullValueHandling = NullValueHandling.Ignore)]
    public string WorkingDir { get; set; }
}

/// <summary>
/// EnvVar represents an environment variable present in a Container.
/// </summary>
public partial class IoK8SApiCoreV1EnvVar
{
    /// <summary>
    /// Name of the environment variable. Must be a C_IDENTIFIER.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Variable references $(VAR_NAME) are expanded using the previous defined environment
    /// variables in the container and any service environment variables. If a variable cannot be
    /// resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can
    /// be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded,
    /// regardless of whether the variable exists or not. Defaults to "".
    /// </summary>
    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public string Value { get; set; }

    /// <summary>
    /// Source for the environment variable's value. Cannot be used if value is not empty.
    /// </summary>
    [JsonProperty("valueFrom", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1EnvVarSource ValueFrom { get; set; }
}

/// <summary>
/// Source for the environment variable's value. Cannot be used if value is not empty.
///
/// EnvVarSource represents a source for the value of an EnvVar.
/// </summary>
public partial class IoK8SApiCoreV1EnvVarSource
{
    /// <summary>
    /// Selects a key of a ConfigMap.
    /// </summary>
    [JsonProperty("configMapKeyRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ConfigMapKeySelector ConfigMapKeyRef { get; set; }

    /// <summary>
    /// Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels,
    /// metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
    /// </summary>
    [JsonProperty("fieldRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ObjectFieldSelector FieldRef { get; set; }

    /// <summary>
    /// Selects a resource of the container: only resources limits and requests (limits.cpu,
    /// limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and
    /// requests.ephemeral-storage) are currently supported.
    /// </summary>
    [JsonProperty("resourceFieldRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ResourceFieldSelector ResourceFieldRef { get; set; }

    /// <summary>
    /// Selects a key of a secret in the pod's namespace
    /// </summary>
    [JsonProperty("secretKeyRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1SecretKeySelector SecretKeyRef { get; set; }
}

/// <summary>
/// Selects a key of a ConfigMap.
///
/// Selects a key from a ConfigMap.
/// </summary>
public partial class IoK8SApiCoreV1ConfigMapKeySelector
{
    /// <summary>
    /// The key to select.
    /// </summary>
    [JsonProperty("key")]
    public string Key { get; set; }

    /// <summary>
    /// Name of the referent. More info:
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Specify whether the ConfigMap or it's key must be defined
    /// </summary>
    [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; }
}

/// <summary>
/// Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels,
/// metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP,
/// status.podIP.
///
/// ObjectFieldSelector selects an APIVersioned field of an object.
///
/// Required: Selects a field of the pod: only annotations, labels, name and namespace are
/// supported.
/// </summary>
public partial class IoK8SApiCoreV1ObjectFieldSelector
{
    /// <summary>
    /// Version of the schema the FieldPath is written in terms of, defaults to "v1".
    /// </summary>
    [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
    public string ApiVersion { get; set; }

    /// <summary>
    /// Path of the field to select in the specified API version.
    /// </summary>
    [JsonProperty("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>
/// Selects a resource of the container: only resources limits and requests (limits.cpu,
/// limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and
/// requests.ephemeral-storage) are currently supported.
///
/// ResourceFieldSelector represents container resources (cpu, memory) and their output
/// format
///
/// Selects a resource of the container: only resources limits and requests (limits.cpu,
/// limits.memory, requests.cpu and requests.memory) are currently supported.
/// </summary>
public partial class IoK8SApiCoreV1ResourceFieldSelector
{
    /// <summary>
    /// Container name: required for volumes, optional for env vars
    /// </summary>
    [JsonProperty("containerName", NullValueHandling = NullValueHandling.Ignore)]
    public string ContainerName { get; set; }

    /// <summary>
    /// Specifies the output format of the exposed resources, defaults to "1"
    /// </summary>
    [JsonProperty("divisor", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApiResourceQuantity? Divisor { get; set; }

    /// <summary>
    /// Required: resource to select
    /// </summary>
    [JsonProperty("resource")]
    public string Resource { get; set; }
}

/// <summary>
/// Selects a key of a secret in the pod's namespace
///
/// SecretKeySelector selects a key of a Secret.
/// </summary>
public partial class IoK8SApiCoreV1SecretKeySelector
{
    /// <summary>
    /// The key of the secret to select from.  Must be a valid secret key.
    /// </summary>
    [JsonProperty("key")]
    public string Key { get; set; }

    /// <summary>
    /// Name of the referent. More info:
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Specify whether the Secret or it's key must be defined
    /// </summary>
    [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; }
}

/// <summary>
/// EnvFromSource represents the source of a set of ConfigMaps
/// </summary>
public partial class IoK8SApiCoreV1EnvFromSource
{
    /// <summary>
    /// The ConfigMap to select from
    /// </summary>
    [JsonProperty("configMapRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ConfigMapEnvSource ConfigMapRef { get; set; }

    /// <summary>
    /// An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.
    /// </summary>
    [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
    public string Prefix { get; set; }

    /// <summary>
    /// The Secret to select from
    /// </summary>
    [JsonProperty("secretRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1SecretEnvSource SecretRef { get; set; }
}

/// <summary>
/// The ConfigMap to select from
///
/// ConfigMapEnvSource selects a ConfigMap to populate the environment variables with.
///
/// The contents of the target ConfigMap's Data field will represent the key-value pairs as
/// environment variables.
/// </summary>
public partial class IoK8SApiCoreV1ConfigMapEnvSource
{
    /// <summary>
    /// Name of the referent. More info:
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Specify whether the ConfigMap must be defined
    /// </summary>
    [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; }
}

/// <summary>
/// The Secret to select from
///
/// SecretEnvSource selects a Secret to populate the environment variables with.
///
/// The contents of the target Secret's Data field will represent the key-value pairs as
/// environment variables.
/// </summary>
public partial class IoK8SApiCoreV1SecretEnvSource
{
    /// <summary>
    /// Name of the referent. More info:
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Specify whether the Secret must be defined
    /// </summary>
    [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; }
}

/// <summary>
/// Actions that the management system should take in response to container lifecycle events.
/// Cannot be updated.
///
/// Lifecycle describes actions that the management system should take in response to
/// container lifecycle events. For the PostStart and PreStop lifecycle handlers, management
/// of the container blocks until the action is complete, unless the container process fails,
/// in which case the handler is aborted.
/// </summary>
public partial class IoK8SApiCoreV1Lifecycle
{
    /// <summary>
    /// PostStart is called immediately after a container is created. If the handler fails, the
    /// container is terminated and restarted according to its restart policy. Other management
    /// of the container blocks until the hook completes. More info:
    /// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
    /// </summary>
    [JsonProperty("postStart", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Handler PostStart { get; set; }

    /// <summary>
    /// PreStop is called immediately before a container is terminated due to an API request or
    /// management event such as liveness probe failure, preemption, resource contention, etc.
    /// The handler is not called if the container crashes or exits. The reason for termination
    /// is passed to the handler. The Pod's termination grace period countdown begins before the
    /// PreStop hooked is executed. Regardless of the outcome of the handler, the container will
    /// eventually terminate within the Pod's termination grace period. Other management of the
    /// container blocks until the hook completes or until the termination grace period is
    /// reached. More info:
    /// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
    /// </summary>
    [JsonProperty("preStop", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Handler PreStop { get; set; }
}

/// <summary>
/// PostStart is called immediately after a container is created. If the handler fails, the
/// container is terminated and restarted according to its restart policy. Other management
/// of the container blocks until the hook completes. More info:
/// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
///
/// Handler defines a specific action that should be taken
///
/// PreStop is called immediately before a container is terminated due to an API request or
/// management event such as liveness probe failure, preemption, resource contention, etc.
/// The handler is not called if the container crashes or exits. The reason for termination
/// is passed to the handler. The Pod's termination grace period countdown begins before the
/// PreStop hooked is executed. Regardless of the outcome of the handler, the container will
/// eventually terminate within the Pod's termination grace period. Other management of the
/// container blocks until the hook completes or until the termination grace period is
/// reached. More info:
/// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
/// </summary>
public partial class IoK8SApiCoreV1Handler
{
    /// <summary>
    /// One and only one of the following should be specified. Exec specifies the action to take.
    /// </summary>
    [JsonProperty("exec", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ExecAction Exec { get; set; }

    /// <summary>
    /// HTTPGet specifies the http request to perform.
    /// </summary>
    [JsonProperty("httpGet", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1HttpGetAction HttpGet { get; set; }

    /// <summary>
    /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported
    /// </summary>
    [JsonProperty("tcpSocket", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1TcpSocketAction TcpSocket { get; set; }
}

/// <summary>
/// One and only one of the following should be specified. Exec specifies the action to
/// take.
///
/// ExecAction describes a "run in container" action.
/// </summary>
public partial class IoK8SApiCoreV1ExecAction
{
    /// <summary>
    /// Command is the command line to execute inside the container, the working directory for
    /// the command  is root ('/') in the container's filesystem. The command is simply exec'd,
    /// it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To
    /// use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated
    /// as live/healthy and non-zero is unhealthy.
    /// </summary>
    [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Command { get; set; }
}

/// <summary>
/// HTTPGet specifies the http request to perform.
///
/// HTTPGetAction describes an action based on HTTP Get requests.
/// </summary>
public partial class IoK8SApiCoreV1HttpGetAction
{
    /// <summary>
    /// Host name to connect to, defaults to the pod IP. You probably want to set "Host" in
    /// httpHeaders instead.
    /// </summary>
    [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
    public string Host { get; set; }

    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers.
    /// </summary>
    [JsonProperty("httpHeaders", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1HttpHeader[] HttpHeaders { get; set; }

    /// <summary>
    /// Path to access on the HTTP server.
    /// </summary>
    [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
    public string Path { get; set; }

    /// <summary>
    /// Name or number of the port to access on the container. Number must be in the range 1 to
    /// 65535. Name must be an IANA_SVC_NAME.
    /// </summary>
    [JsonProperty("port")]
    public IoK8SApimachineryPkgUtilIntstrIntOrString Port { get; set; }

    /// <summary>
    /// Scheme to use for connecting to the host. Defaults to HTTP.
    /// </summary>
    [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
    public string Scheme { get; set; }
}

/// <summary>
/// HTTPHeader describes a custom header to be used in HTTP probes
/// </summary>
public partial class IoK8SApiCoreV1HttpHeader
{
    /// <summary>
    /// The header field name
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The header field value
    /// </summary>
    [JsonProperty("value")]
    public string Value { get; set; }
}

/// <summary>
/// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported
///
/// TCPSocketAction describes an action based on opening a socket
/// </summary>
public partial class IoK8SApiCoreV1TcpSocketAction
{
    /// <summary>
    /// Optional: Host name to connect to, defaults to the pod IP.
    /// </summary>
    [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
    public string Host { get; set; }

    /// <summary>
    /// Number or name of the port to access on the container. Number must be in the range 1 to
    /// 65535. Name must be an IANA_SVC_NAME.
    /// </summary>
    [JsonProperty("port")]
    public IoK8SApimachineryPkgUtilIntstrIntOrString Port { get; set; }
}

/// <summary>
/// Periodic probe of container liveness. Container will be restarted if the probe fails.
/// Cannot be updated. More info:
/// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
///
/// Probe describes a health check to be performed against a container to determine whether
/// it is alive or ready to receive traffic.
///
/// Periodic probe of container service readiness. Container will be removed from service
/// endpoints if the probe fails. Cannot be updated. More info:
/// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
/// </summary>
public partial class IoK8SApiCoreV1Probe
{
    /// <summary>
    /// One and only one of the following should be specified. Exec specifies the action to take.
    /// </summary>
    [JsonProperty("exec", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ExecAction Exec { get; set; }

    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after having
    /// succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    [JsonProperty("failureThreshold", NullValueHandling = NullValueHandling.Ignore)]
    public long? FailureThreshold { get; set; }

    /// <summary>
    /// HTTPGet specifies the http request to perform.
    /// </summary>
    [JsonProperty("httpGet", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1HttpGetAction HttpGet { get; set; }

    /// <summary>
    /// Number of seconds after the container has started before liveness probes are initiated.
    /// More info:
    /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    [JsonProperty("initialDelaySeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? InitialDelaySeconds { get; set; }

    /// <summary>
    /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.
    /// </summary>
    [JsonProperty("periodSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? PeriodSeconds { get; set; }

    /// <summary>
    /// Minimum consecutive successes for the probe to be considered successful after having
    /// failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.
    /// </summary>
    [JsonProperty("successThreshold", NullValueHandling = NullValueHandling.Ignore)]
    public long? SuccessThreshold { get; set; }

    /// <summary>
    /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported
    /// </summary>
    [JsonProperty("tcpSocket", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1TcpSocketAction TcpSocket { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is
    /// 1. More info:
    /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    [JsonProperty("timeoutSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? TimeoutSeconds { get; set; }
}

/// <summary>
/// ContainerPort represents a network port in a single container.
/// </summary>
public partial class IoK8SApiCoreV1ContainerPort
{
    /// <summary>
    /// Number of port to expose on the pod's IP address. This must be a valid port number, 0 < x
    /// < 65536.
    /// </summary>
    [JsonProperty("containerPort")]
    public long ContainerPort { get; set; }

    /// <summary>
    /// What host IP to bind the external port to.
    /// </summary>
    [JsonProperty("hostIP", NullValueHandling = NullValueHandling.Ignore)]
    public string HostIp { get; set; }

    /// <summary>
    /// Number of port to expose on the host. If specified, this must be a valid port number, 0 <
    /// x < 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do
    /// not need this.
    /// </summary>
    [JsonProperty("hostPort", NullValueHandling = NullValueHandling.Ignore)]
    public long? HostPort { get; set; }

    /// <summary>
    /// If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in
    /// a pod must have a unique name. Name for the port that can be referred to by services.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Protocol for port. Must be UDP, TCP, or SCTP. Defaults to "TCP".
    /// </summary>
    [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
    public string Protocol { get; set; }
}

/// <summary>
/// Compute Resources required by this container. Cannot be updated. More info:
/// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
///
/// ResourceRequirements describes the compute resource requirements.
/// </summary>
public partial class IoK8SApiCoreV1ResourceRequirements
{
    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed. More info:
    /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
    /// </summary>
    [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, IoK8SApimachineryPkgApiResourceQuantity> Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required. If Requests is
    /// omitted for a container, it defaults to Limits if that is explicitly specified, otherwise
    /// to an implementation-defined value. More info:
    /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
    /// </summary>
    [JsonProperty("requests", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, IoK8SApimachineryPkgApiResourceQuantity> Requests { get; set; }
}

/// <summary>
/// Security options the pod should run with. More info:
/// https://kubernetes.io/docs/concepts/policy/security-context/ More info:
/// https://kubernetes.io/docs/tasks/configure-pod-container/security-context/
///
/// SecurityContext holds security configuration that will be applied to a container. Some
/// fields are present in both SecurityContext and PodSecurityContext.  When both are set,
/// the values in SecurityContext take precedence.
/// </summary>
public partial class IoK8SApiCoreV1SecurityContext
{
    /// <summary>
    /// AllowPrivilegeEscalation controls whether a process can gain more privileges than its
    /// parent process. This bool directly controls if the no_new_privs flag will be set on the
    /// container process. AllowPrivilegeEscalation is true always when the container is: 1) run
    /// as Privileged 2) has CAP_SYS_ADMIN
    /// </summary>
    [JsonProperty("allowPrivilegeEscalation", NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>
    /// The capabilities to add/drop when running containers. Defaults to the default set of
    /// capabilities granted by the container runtime.
    /// </summary>
    [JsonProperty("capabilities", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Capabilities Capabilities { get; set; }

    /// <summary>
    /// Run container in privileged mode. Processes in privileged containers are essentially
    /// equivalent to root on the host. Defaults to false.
    /// </summary>
    [JsonProperty("privileged", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Privileged { get; set; }

    /// <summary>
    /// procMount denotes the type of proc mount to use for the containers. The default is
    /// DefaultProcMount which uses the container runtime defaults for readonly paths and masked
    /// paths. This requires the ProcMountType feature flag to be enabled.
    /// </summary>
    [JsonProperty("procMount", NullValueHandling = NullValueHandling.Ignore)]
    public string ProcMount { get; set; }

    /// <summary>
    /// Whether this container has a read-only root filesystem. Default is false.
    /// </summary>
    [JsonProperty("readOnlyRootFilesystem", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary>
    /// The GID to run the entrypoint of the container process. Uses runtime default if unset.
    /// May also be set in PodSecurityContext.  If set in both SecurityContext and
    /// PodSecurityContext, the value specified in SecurityContext takes precedence.
    /// </summary>
    [JsonProperty("runAsGroup", NullValueHandling = NullValueHandling.Ignore)]
    public long? RunAsGroup { get; set; }

    /// <summary>
    /// Indicates that the container must run as a non-root user. If true, the Kubelet will
    /// validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to
    /// start the container if it does. If unset or false, no such validation will be performed.
    /// May also be set in PodSecurityContext.  If set in both SecurityContext and
    /// PodSecurityContext, the value specified in SecurityContext takes precedence.
    /// </summary>
    [JsonProperty("runAsNonRoot", NullValueHandling = NullValueHandling.Ignore)]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>
    /// The UID to run the entrypoint of the container process. Defaults to user specified in
    /// image metadata if unspecified. May also be set in PodSecurityContext.  If set in both
    /// SecurityContext and PodSecurityContext, the value specified in SecurityContext takes
    /// precedence.
    /// </summary>
    [JsonProperty("runAsUser", NullValueHandling = NullValueHandling.Ignore)]
    public long? RunAsUser { get; set; }

    /// <summary>
    /// The SELinux context to be applied to the container. If unspecified, the container runtime
    /// will allocate a random SELinux context for each container.  May also be set in
    /// PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value
    /// specified in SecurityContext takes precedence.
    /// </summary>
    [JsonProperty("seLinuxOptions", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1SeLinuxOptions SeLinuxOptions { get; set; }
}

/// <summary>
/// The capabilities to add/drop when running containers. Defaults to the default set of
/// capabilities granted by the container runtime.
///
/// Adds and removes POSIX capabilities from running containers.
/// </summary>
public partial class IoK8SApiCoreV1Capabilities
{
    /// <summary>
    /// Added capabilities
    /// </summary>
    [JsonProperty("add", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Add { get; set; }

    /// <summary>
    /// Removed capabilities
    /// </summary>
    [JsonProperty("drop", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Drop { get; set; }
}

/// <summary>
/// The SELinux context to be applied to the container. If unspecified, the container runtime
/// will allocate a random SELinux context for each container.  May also be set in
/// PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value
/// specified in SecurityContext takes precedence.
///
/// SELinuxOptions are the labels to be applied to the container
///
/// The SELinux context to be applied to all containers. If unspecified, the container
/// runtime will allocate a random SELinux context for each container.  May also be set in
/// SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value
/// specified in SecurityContext takes precedence for that container.
/// </summary>
public partial class IoK8SApiCoreV1SeLinuxOptions
{
    /// <summary>
    /// Level is SELinux level label that applies to the container.
    /// </summary>
    [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
    public string Level { get; set; }

    /// <summary>
    /// Role is a SELinux role label that applies to the container.
    /// </summary>
    [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
    public string Role { get; set; }

    /// <summary>
    /// Type is a SELinux type label that applies to the container.
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    /// <summary>
    /// User is a SELinux user label that applies to the container.
    /// </summary>
    [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
    public string User { get; set; }
}

/// <summary>
/// volumeDevice describes a mapping of a raw block device within a container.
/// </summary>
public partial class IoK8SApiCoreV1VolumeDevice
{
    /// <summary>
    /// devicePath is the path inside of the container that the device will be mapped to.
    /// </summary>
    [JsonProperty("devicePath")]
    public string DevicePath { get; set; }

    /// <summary>
    /// name must match the name of a persistentVolumeClaim in the pod
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
}

/// <summary>
/// VolumeMount describes a mounting of a Volume within a container.
/// </summary>
public partial class IoK8SApiCoreV1VolumeMount
{
    /// <summary>
    /// Path within the container at which the volume should be mounted.  Must not contain ':'.
    /// </summary>
    [JsonProperty("mountPath")]
    public string MountPath { get; set; }

    /// <summary>
    /// mountPropagation determines how mounts are propagated from the host to container and the
    /// other way around. When not set, MountPropagationNone is used. This field is beta in 1.10.
    /// </summary>
    [JsonProperty("mountPropagation", NullValueHandling = NullValueHandling.Ignore)]
    public string MountPropagation { get; set; }

    /// <summary>
    /// This must match the Name of a Volume.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Path within the volume from which the container's volume should be mounted. Defaults to
    /// "" (volume's root).
    /// </summary>
    [JsonProperty("subPath", NullValueHandling = NullValueHandling.Ignore)]
    public string SubPath { get; set; }

    /// <summary>
    /// Expanded path within the volume from which the container's volume should be mounted.
    /// Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded
    /// using the container's environment. Defaults to "" (volume's root). SubPathExpr and
    /// SubPath are mutually exclusive. This field is alpha in 1.14.
    /// </summary>
    [JsonProperty("subPathExpr", NullValueHandling = NullValueHandling.Ignore)]
    public string SubPathExpr { get; set; }
}

/// <summary>
/// Specifies the DNS parameters of a pod. Parameters specified here will be merged to the
/// generated DNS configuration based on DNSPolicy.
///
/// PodDNSConfig defines the DNS parameters of a pod in addition to those generated from
/// DNSPolicy.
/// </summary>
public partial class IoK8SApiCoreV1PodDnsConfig
{
    /// <summary>
    /// A list of DNS name server IP addresses. This will be appended to the base nameservers
    /// generated from DNSPolicy. Duplicated nameservers will be removed.
    /// </summary>
    [JsonProperty("nameservers", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Nameservers { get; set; }

    /// <summary>
    /// A list of DNS resolver options. This will be merged with the base options generated from
    /// DNSPolicy. Duplicated entries will be removed. Resolution options given in Options will
    /// override those that appear in the base DNSPolicy.
    /// </summary>
    [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PodDnsConfigOption[] Options { get; set; }

    /// <summary>
    /// A list of DNS search domains for host-name lookup. This will be appended to the base
    /// search paths generated from DNSPolicy. Duplicated search paths will be removed.
    /// </summary>
    [JsonProperty("searches", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Searches { get; set; }
}

/// <summary>
/// PodDNSConfigOption defines DNS resolver options of a pod.
/// </summary>
public partial class IoK8SApiCoreV1PodDnsConfigOption
{
    /// <summary>
    /// Required.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public string Value { get; set; }
}

/// <summary>
/// HostAlias holds the mapping between IP and hostnames that will be injected as an entry in
/// the pod's hosts file.
/// </summary>
public partial class IoK8SApiCoreV1HostAlias
{
    /// <summary>
    /// Hostnames for the above IP address.
    /// </summary>
    [JsonProperty("hostnames", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Hostnames { get; set; }

    /// <summary>
    /// IP address of the host file entry.
    /// </summary>
    [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
    public string Ip { get; set; }
}

/// <summary>
/// LocalObjectReference contains enough information to let you locate the referenced object
/// inside the same namespace.
///
/// Optional: SecretRef is reference to the authentication secret for User, default is empty.
/// More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
///
/// Optional: points to a secret object containing parameters used to connect to OpenStack.
///
/// NodePublishSecretRef is a reference to the secret object containing sensitive information
/// to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume
/// calls. This field is optional, and  may be empty if no secret is required. If the secret
/// object contains more than one secret, all secret references are passed.
///
/// Optional: SecretRef is reference to the secret object containing sensitive information to
/// pass to the plugin scripts. This may be empty if no secret object is specified. If the
/// secret object contains more than one secret, all secrets are passed to the plugin
/// scripts.
///
/// CHAP Secret for iSCSI target and initiator authentication
///
/// SecretRef is name of the authentication secret for RBDUser. If provided overrides
/// keyring. Default is nil. More info:
/// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
///
/// SecretRef references to the secret for ScaleIO user and other sensitive information. If
/// this is not provided, Login operation will fail.
///
/// SecretRef specifies the secret to use for obtaining the StorageOS API credentials.  If
/// not specified, default values will be attempted.
/// </summary>
public partial class IoK8SApiCoreV1LocalObjectReference
{
    /// <summary>
    /// Name of the referent. More info:
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
}

/// <summary>
/// PodReadinessGate contains the reference to a pod condition
/// </summary>
public partial class IoK8SApiCoreV1PodReadinessGate
{
    /// <summary>
    /// ConditionType refers to a condition in the pod's condition list with matching type.
    /// </summary>
    [JsonProperty("conditionType")]
    public string ConditionType { get; set; }
}

/// <summary>
/// SecurityContext holds pod-level security attributes and common container settings.
/// Optional: Defaults to empty.  See type description for default values of each field.
///
/// PodSecurityContext holds pod-level security attributes and common container settings.
/// Some fields are also present in container.securityContext.  Field values of
/// container.securityContext take precedence over field values of PodSecurityContext.
/// </summary>
public partial class IoK8SApiCoreV1PodSecurityContext
{
    /// <summary>
    /// A special supplemental group that applies to all containers in a pod. Some volume types
    /// allow the Kubelet to change the ownership of that volume to be owned by the pod:
    ///
    /// 1. The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the
    /// volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw----
    ///
    /// If unset, the Kubelet will not modify the ownership and permissions of any volume.
    /// </summary>
    [JsonProperty("fsGroup", NullValueHandling = NullValueHandling.Ignore)]
    public long? FsGroup { get; set; }

    /// <summary>
    /// The GID to run the entrypoint of the container process. Uses runtime default if unset.
    /// May also be set in SecurityContext.  If set in both SecurityContext and
    /// PodSecurityContext, the value specified in SecurityContext takes precedence for that
    /// container.
    /// </summary>
    [JsonProperty("runAsGroup", NullValueHandling = NullValueHandling.Ignore)]
    public long? RunAsGroup { get; set; }

    /// <summary>
    /// Indicates that the container must run as a non-root user. If true, the Kubelet will
    /// validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to
    /// start the container if it does. If unset or false, no such validation will be performed.
    /// May also be set in SecurityContext.  If set in both SecurityContext and
    /// PodSecurityContext, the value specified in SecurityContext takes precedence.
    /// </summary>
    [JsonProperty("runAsNonRoot", NullValueHandling = NullValueHandling.Ignore)]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>
    /// The UID to run the entrypoint of the container process. Defaults to user specified in
    /// image metadata if unspecified. May also be set in SecurityContext.  If set in both
    /// SecurityContext and PodSecurityContext, the value specified in SecurityContext takes
    /// precedence for that container.
    /// </summary>
    [JsonProperty("runAsUser", NullValueHandling = NullValueHandling.Ignore)]
    public long? RunAsUser { get; set; }

    /// <summary>
    /// The SELinux context to be applied to all containers. If unspecified, the container
    /// runtime will allocate a random SELinux context for each container.  May also be set in
    /// SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value
    /// specified in SecurityContext takes precedence for that container.
    /// </summary>
    [JsonProperty("seLinuxOptions", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1SeLinuxOptions SeLinuxOptions { get; set; }

    /// <summary>
    /// A list of groups applied to the first process run in each container, in addition to the
    /// container's primary GID.  If unspecified, no groups will be added to any container.
    /// </summary>
    [JsonProperty("supplementalGroups", NullValueHandling = NullValueHandling.Ignore)]
    public long[] SupplementalGroups { get; set; }

    /// <summary>
    /// Sysctls hold a list of namespaced sysctls used for the pod. Pods with unsupported sysctls
    /// (by the container runtime) might fail to launch.
    /// </summary>
    [JsonProperty("sysctls", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1Sysctl[] Sysctls { get; set; }
}

/// <summary>
/// Sysctl defines a kernel parameter to be set
/// </summary>
public partial class IoK8SApiCoreV1Sysctl
{
    /// <summary>
    /// Name of a property to set
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Value of a property to set
    /// </summary>
    [JsonProperty("value")]
    public string Value { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches the triple
/// <key,value,effect> using the matching operator <operator>.
/// </summary>
public partial class IoK8SApiCoreV1Toleration
{
    /// <summary>
    /// Effect indicates the taint effect to match. Empty means match all taint effects. When
    /// specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
    /// </summary>
    [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
    public string Effect { get; set; }

    /// <summary>
    /// Key is the taint key that the toleration applies to. Empty means match all taint keys. If
    /// the key is empty, operator must be Exists; this combination means to match all values and
    /// all keys.
    /// </summary>
    [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
    public string Key { get; set; }

    /// <summary>
    /// Operator represents a key's relationship to the value. Valid operators are Exists and
    /// Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can
    /// tolerate all taints of a particular category.
    /// </summary>
    [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
    public string Operator { get; set; }

    /// <summary>
    /// TolerationSeconds represents the period of time the toleration (which must be of effect
    /// NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not
    /// set, which means tolerate the taint forever (do not evict). Zero and negative values will
    /// be treated as 0 (evict immediately) by the system.
    /// </summary>
    [JsonProperty("tolerationSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? TolerationSeconds { get; set; }

    /// <summary>
    /// Value is the taint value the toleration matches to. If the operator is Exists, the value
    /// should be empty, otherwise just a regular string.
    /// </summary>
    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public string Value { get; set; }
}

/// <summary>
/// Volume represents a named volume in a pod that may be accessed by any container in the
/// pod.
/// </summary>
public partial class IoK8SApiCoreV1Volume
{
    /// <summary>
    /// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host
    /// machine and then exposed to the pod. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
    /// </summary>
    [JsonProperty("awsElasticBlockStore", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1AwsElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

    /// <summary>
    /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
    /// </summary>
    [JsonProperty("azureDisk", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1AzureDiskVolumeSource AzureDisk { get; set; }

    /// <summary>
    /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
    /// </summary>
    [JsonProperty("azureFile", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1AzureFileVolumeSource AzureFile { get; set; }

    /// <summary>
    /// CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
    /// </summary>
    [JsonProperty("cephfs", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1CephFsVolumeSource Cephfs { get; set; }

    /// <summary>
    /// Cinder represents a cinder volume attached and mounted on kubelets host machine More
    /// info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
    /// </summary>
    [JsonProperty("cinder", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1CinderVolumeSource Cinder { get; set; }

    /// <summary>
    /// ConfigMap represents a configMap that should populate this volume
    /// </summary>
    [JsonProperty("configMap", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ConfigMapVolumeSource ConfigMap { get; set; }

    /// <summary>
    /// CSI (Container Storage Interface) represents storage that is handled by an external CSI
    /// driver (Alpha feature).
    /// </summary>
    [JsonProperty("csi", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1CsiVolumeSource Csi { get; set; }

    /// <summary>
    /// DownwardAPI represents downward API about the pod that should populate this volume
    /// </summary>
    [JsonProperty("downwardAPI", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1DownwardApiVolumeSource DownwardApi { get; set; }

    /// <summary>
    /// EmptyDir represents a temporary directory that shares a pod's lifetime. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#emptydir
    /// </summary>
    [JsonProperty("emptyDir", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1EmptyDirVolumeSource EmptyDir { get; set; }

    /// <summary>
    /// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and
    /// then exposed to the pod.
    /// </summary>
    [JsonProperty("fc", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1FcVolumeSource Fc { get; set; }

    /// <summary>
    /// FlexVolume represents a generic volume resource that is provisioned/attached using an
    /// exec based plugin.
    /// </summary>
    [JsonProperty("flexVolume", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1FlexVolumeSource FlexVolume { get; set; }

    /// <summary>
    /// Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on
    /// the Flocker control service being running
    /// </summary>
    [JsonProperty("flocker", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1FlockerVolumeSource Flocker { get; set; }

    /// <summary>
    /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host
    /// machine and then exposed to the pod. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
    /// </summary>
    [JsonProperty("gcePersistentDisk", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1GcePersistentDiskVolumeSource GcePersistentDisk { get; set; }

    /// <summary>
    /// GitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is
    /// deprecated. To provision a container with a git repo, mount an EmptyDir into an
    /// InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's
    /// container.
    /// </summary>
    [JsonProperty("gitRepo", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1GitRepoVolumeSource GitRepo { get; set; }

    /// <summary>
    /// Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More
    /// info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
    /// </summary>
    [JsonProperty("glusterfs", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1GlusterfsVolumeSource Glusterfs { get; set; }

    /// <summary>
    /// HostPath represents a pre-existing file or directory on the host machine that is directly
    /// exposed to the container. This is generally used for system agents or other privileged
    /// things that are allowed to see the host machine. Most containers will NOT need this. More
    /// info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
    /// </summary>
    [JsonProperty("hostPath", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1HostPathVolumeSource HostPath { get; set; }

    /// <summary>
    /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and
    /// then exposed to the pod. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/iscsi/README.md
    /// </summary>
    [JsonProperty("iscsi", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1IscsiVolumeSource Iscsi { get; set; }

    /// <summary>
    /// Volume's name. Must be a DNS_LABEL and unique within the pod. More info:
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// NFS represents an NFS mount on the host that shares a pod's lifetime More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#nfs
    /// </summary>
    [JsonProperty("nfs", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1NfsVolumeSource Nfs { get; set; }

    /// <summary>
    /// PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in
    /// the same namespace. More info:
    /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
    /// </summary>
    [JsonProperty("persistentVolumeClaim", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PersistentVolumeClaimVolumeSource PersistentVolumeClaim { get; set; }

    /// <summary>
    /// PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted
    /// on kubelets host machine
    /// </summary>
    [JsonProperty("photonPersistentDisk", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

    /// <summary>
    /// PortworxVolume represents a portworx volume attached and mounted on kubelets host machine
    /// </summary>
    [JsonProperty("portworxVolume", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1PortworxVolumeSource PortworxVolume { get; set; }

    /// <summary>
    /// Items for all in one resources secrets, configmaps, and downward API
    /// </summary>
    [JsonProperty("projected", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ProjectedVolumeSource Projected { get; set; }

    /// <summary>
    /// Quobyte represents a Quobyte mount on the host that shares a pod's lifetime
    /// </summary>
    [JsonProperty("quobyte", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1QuobyteVolumeSource Quobyte { get; set; }

    /// <summary>
    /// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More
    /// info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md
    /// </summary>
    [JsonProperty("rbd", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1RbdVolumeSource Rbd { get; set; }

    /// <summary>
    /// ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
    /// </summary>
    [JsonProperty("scaleIO", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ScaleIoVolumeSource ScaleIo { get; set; }

    /// <summary>
    /// Secret represents a secret that should populate this volume. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#secret
    /// </summary>
    [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1SecretVolumeSource Secret { get; set; }

    /// <summary>
    /// StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.
    /// </summary>
    [JsonProperty("storageos", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1StorageOsVolumeSource Storageos { get; set; }

    /// <summary>
    /// VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
    /// </summary>
    [JsonProperty("vsphereVolume", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }
}

/// <summary>
/// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host
/// machine and then exposed to the pod. More info:
/// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
///
/// Represents a Persistent Disk resource in AWS.
///
/// An AWS EBS disk must exist before mounting to a container. The disk must also be in the
/// same AWS zone as the kubelet. An AWS EBS disk can only be mounted as read/write once. AWS
/// EBS volumes support ownership management and SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1AwsElasticBlockStoreVolumeSource
{
    /// <summary>
    /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem
    /// type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs".
    /// Implicitly inferred to be "ext4" if unspecified. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// The partition in the volume that you want to mount. If omitted, the default is to mount
    /// by volume name. Examples: For volume /dev/sda1, you specify the partition as "1".
    /// Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty).
    /// </summary>
    [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
    public long? Partition { get; set; }

    /// <summary>
    /// Specify "true" to force and set the ReadOnly property in VolumeMounts to "true". If
    /// omitted, the default is "false". More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
    /// </summary>
    [JsonProperty("volumeID")]
    public string VolumeId { get; set; }
}

/// <summary>
/// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
/// </summary>
public partial class IoK8SApiCoreV1AzureDiskVolumeSource
{
    /// <summary>
    /// Host Caching mode: None, Read Only, Read Write.
    /// </summary>
    [JsonProperty("cachingMode", NullValueHandling = NullValueHandling.Ignore)]
    public string CachingMode { get; set; }

    /// <summary>
    /// The Name of the data disk in the blob storage
    /// </summary>
    [JsonProperty("diskName")]
    public string DiskName { get; set; }

    /// <summary>
    /// The URI the data disk in the blob storage
    /// </summary>
    [JsonProperty("diskURI")]
    public string DiskUri { get; set; }

    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating
    /// system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// Expected values Shared: multiple blob disks per storage account  Dedicated: single blob
    /// disk per storage account  Managed: azure managed data disk (only in managed availability
    /// set). defaults to shared
    /// </summary>
    [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
    public string Kind { get; set; }

    /// <summary>
    /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in
    /// VolumeMounts.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }
}

/// <summary>
/// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
/// </summary>
public partial class IoK8SApiCoreV1AzureFileVolumeSource
{
    /// <summary>
    /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in
    /// VolumeMounts.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// the name of secret that contains Azure Storage Account Name and Key
    /// </summary>
    [JsonProperty("secretName")]
    public string SecretName { get; set; }

    /// <summary>
    /// Share Name
    /// </summary>
    [JsonProperty("shareName")]
    public string ShareName { get; set; }
}

/// <summary>
/// CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
///
/// Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not
/// support ownership management or SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1CephFsVolumeSource
{
    /// <summary>
    /// Required: Monitors is a collection of Ceph monitors More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("monitors")]
    public string[] Monitors { get; set; }

    /// <summary>
    /// Optional: Used as the mounted root, rather than the full Ceph tree, default is /
    /// </summary>
    [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
    public string Path { get; set; }

    /// <summary>
    /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting
    /// in VolumeMounts. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret
    /// More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("secretFile", NullValueHandling = NullValueHandling.Ignore)]
    public string SecretFile { get; set; }

    /// <summary>
    /// Optional: SecretRef is reference to the authentication secret for User, default is empty.
    /// More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("secretRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1LocalObjectReference SecretRef { get; set; }

    /// <summary>
    /// Optional: User is the rados user name, default is admin More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
    public string User { get; set; }
}

/// <summary>
/// Cinder represents a cinder volume attached and mounted on kubelets host machine More
/// info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
///
/// Represents a cinder volume resource in Openstack. A Cinder volume must exist before
/// mounting to a container. The volume must also be in the same region as the kubelet.
/// Cinder volumes support ownership management and SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1CinderVolumeSource
{
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating
    /// system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
    /// More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting
    /// in VolumeMounts. More info:
    /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Optional: points to a secret object containing parameters used to connect to OpenStack.
    /// </summary>
    [JsonProperty("secretRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1LocalObjectReference SecretRef { get; set; }

    /// <summary>
    /// volume id used to identify the volume in cinder More info:
    /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
    /// </summary>
    [JsonProperty("volumeID")]
    public string VolumeId { get; set; }
}

/// <summary>
/// ConfigMap represents a configMap that should populate this volume
///
/// Adapts a ConfigMap into a volume.
///
/// The contents of the target ConfigMap's Data field will be presented in a volume as files
/// using the keys in the Data field as the file names, unless the items element is populated
/// with specific mappings of keys to paths. ConfigMap volumes support ownership management
/// and SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1ConfigMapVolumeSource
{
    /// <summary>
    /// Optional: mode bits to use on created files by default. Must be a value between 0 and
    /// 0777. Defaults to 0644. Directories within the path are not affected by this setting.
    /// This might be in conflict with other options that affect the file mode, like fsGroup, and
    /// the result can be other mode bits set.
    /// </summary>
    [JsonProperty("defaultMode", NullValueHandling = NullValueHandling.Ignore)]
    public long? DefaultMode { get; set; }

    /// <summary>
    /// If unspecified, each key-value pair in the Data field of the referenced ConfigMap will be
    /// projected into the volume as a file whose name is the key and content is the value. If
    /// specified, the listed keys will be projected into the specified paths, and unlisted keys
    /// will not be present. If a key is specified which is not present in the ConfigMap, the
    /// volume setup will error unless it is marked optional. Paths must be relative and may not
    /// contain the '..' path or start with '..'.
    /// </summary>
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1KeyToPath[] Items { get; set; }

    /// <summary>
    /// Name of the referent. More info:
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Specify whether the ConfigMap or it's keys must be defined
    /// </summary>
    [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; }
}

/// <summary>
/// Maps a string key to a path within a volume.
/// </summary>
public partial class IoK8SApiCoreV1KeyToPath
{
    /// <summary>
    /// The key to project.
    /// </summary>
    [JsonProperty("key")]
    public string Key { get; set; }

    /// <summary>
    /// Optional: mode bits to use on this file, must be a value between 0 and 0777. If not
    /// specified, the volume defaultMode will be used. This might be in conflict with other
    /// options that affect the file mode, like fsGroup, and the result can be other mode bits
    /// set.
    /// </summary>
    [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
    public long? Mode { get; set; }

    /// <summary>
    /// The relative path of the file to map the key to. May not be an absolute path. May not
    /// contain the path element '..'. May not start with the string '..'.
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; }
}

/// <summary>
/// CSI (Container Storage Interface) represents storage that is handled by an external CSI
/// driver (Alpha feature).
///
/// Represents a source location of a volume to mount, managed by an external CSI driver
/// </summary>
public partial class IoK8SApiCoreV1CsiVolumeSource
{
    /// <summary>
    /// Driver is the name of the CSI driver that handles this volume. Consult with your admin
    /// for the correct name as registered in the cluster.
    /// </summary>
    [JsonProperty("driver")]
    public string Driver { get; set; }

    /// <summary>
    /// Filesystem type to mount. Ex. "ext4", "xfs", "ntfs". If not provided, the empty value is
    /// passed to the associated CSI driver which will determine the default filesystem to apply.
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// NodePublishSecretRef is a reference to the secret object containing sensitive information
    /// to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume
    /// calls. This field is optional, and  may be empty if no secret is required. If the secret
    /// object contains more than one secret, all secret references are passed.
    /// </summary>
    [JsonProperty("nodePublishSecretRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1LocalObjectReference NodePublishSecretRef { get; set; }

    /// <summary>
    /// Specifies a read-only configuration for the volume. Defaults to false (read/write).
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// VolumeAttributes stores driver-specific properties that are passed to the CSI driver.
    /// Consult your driver's documentation for supported values.
    /// </summary>
    [JsonProperty("volumeAttributes", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, string> VolumeAttributes { get; set; }
}

/// <summary>
/// DownwardAPI represents downward API about the pod that should populate this volume
///
/// DownwardAPIVolumeSource represents a volume containing downward API info. Downward API
/// volumes support ownership management and SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1DownwardApiVolumeSource
{
    /// <summary>
    /// Optional: mode bits to use on created files by default. Must be a value between 0 and
    /// 0777. Defaults to 0644. Directories within the path are not affected by this setting.
    /// This might be in conflict with other options that affect the file mode, like fsGroup, and
    /// the result can be other mode bits set.
    /// </summary>
    [JsonProperty("defaultMode", NullValueHandling = NullValueHandling.Ignore)]
    public long? DefaultMode { get; set; }

    /// <summary>
    /// Items is a list of downward API volume file
    /// </summary>
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1DownwardApiVolumeFile[] Items { get; set; }
}

/// <summary>
/// DownwardAPIVolumeFile represents information to create the file containing the pod field
/// </summary>
public partial class IoK8SApiCoreV1DownwardApiVolumeFile
{
    /// <summary>
    /// Required: Selects a field of the pod: only annotations, labels, name and namespace are
    /// supported.
    /// </summary>
    [JsonProperty("fieldRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ObjectFieldSelector FieldRef { get; set; }

    /// <summary>
    /// Optional: mode bits to use on this file, must be a value between 0 and 0777. If not
    /// specified, the volume defaultMode will be used. This might be in conflict with other
    /// options that affect the file mode, like fsGroup, and the result can be other mode bits
    /// set.
    /// </summary>
    [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
    public long? Mode { get; set; }

    /// <summary>
    /// Required: Path is  the relative path name of the file to be created. Must not be absolute
    /// or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must
    /// not start with '..'
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; }

    /// <summary>
    /// Selects a resource of the container: only resources limits and requests (limits.cpu,
    /// limits.memory, requests.cpu and requests.memory) are currently supported.
    /// </summary>
    [JsonProperty("resourceFieldRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ResourceFieldSelector ResourceFieldRef { get; set; }
}

/// <summary>
/// EmptyDir represents a temporary directory that shares a pod's lifetime. More info:
/// https://kubernetes.io/docs/concepts/storage/volumes#emptydir
///
/// Represents an empty directory for a pod. Empty directory volumes support ownership
/// management and SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1EmptyDirVolumeSource
{
    /// <summary>
    /// What type of storage medium should back this directory. The default is "" which means to
    /// use the node's default medium. Must be an empty string (default) or Memory. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#emptydir
    /// </summary>
    [JsonProperty("medium", NullValueHandling = NullValueHandling.Ignore)]
    public string Medium { get; set; }

    /// <summary>
    /// Total amount of local storage required for this EmptyDir volume. The size limit is also
    /// applicable for memory medium. The maximum usage on memory medium EmptyDir would be the
    /// minimum value between the SizeLimit specified here and the sum of memory limits of all
    /// containers in a pod. The default is nil which means that the limit is undefined. More
    /// info: http://kubernetes.io/docs/user-guide/volumes#emptydir
    /// </summary>
    [JsonProperty("sizeLimit", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApimachineryPkgApiResourceQuantity? SizeLimit { get; set; }
}

/// <summary>
/// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and
/// then exposed to the pod.
///
/// Represents a Fibre Channel volume. Fibre Channel volumes can only be mounted as
/// read/write once. Fibre Channel volumes support ownership management and SELinux
/// relabeling.
/// </summary>
public partial class IoK8SApiCoreV1FcVolumeSource
{
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating
    /// system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// Optional: FC target lun number
    /// </summary>
    [JsonProperty("lun", NullValueHandling = NullValueHandling.Ignore)]
    public long? Lun { get; set; }

    /// <summary>
    /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting
    /// in VolumeMounts.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Optional: FC target worldwide names (WWNs)
    /// </summary>
    [JsonProperty("targetWWNs", NullValueHandling = NullValueHandling.Ignore)]
    public string[] TargetWwNs { get; set; }

    /// <summary>
    /// Optional: FC volume world wide identifiers (wwids) Either wwids or combination of
    /// targetWWNs and lun must be set, but not both simultaneously.
    /// </summary>
    [JsonProperty("wwids", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Wwids { get; set; }
}

/// <summary>
/// FlexVolume represents a generic volume resource that is provisioned/attached using an
/// exec based plugin.
/// </summary>
public partial class IoK8SApiCoreV1FlexVolumeSource
{
    /// <summary>
    /// Driver is the name of the driver to use for this volume.
    /// </summary>
    [JsonProperty("driver")]
    public string Driver { get; set; }

    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating
    /// system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// Optional: Extra command options if any.
    /// </summary>
    [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, string> Options { get; set; }

    /// <summary>
    /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting
    /// in VolumeMounts.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Optional: SecretRef is reference to the secret object containing sensitive information to
    /// pass to the plugin scripts. This may be empty if no secret object is specified. If the
    /// secret object contains more than one secret, all secrets are passed to the plugin scripts.
    /// </summary>
    [JsonProperty("secretRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1LocalObjectReference SecretRef { get; set; }
}

/// <summary>
/// Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on
/// the Flocker control service being running
///
/// Represents a Flocker volume mounted by the Flocker agent. One and only one of datasetName
/// and datasetUUID should be set. Flocker volumes do not support ownership management or
/// SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1FlockerVolumeSource
{
    /// <summary>
    /// Name of the dataset stored as metadata -> name on the dataset for Flocker should be
    /// considered as deprecated
    /// </summary>
    [JsonProperty("datasetName", NullValueHandling = NullValueHandling.Ignore)]
    public string DatasetName { get; set; }

    /// <summary>
    /// UUID of the dataset. This is unique identifier of a Flocker dataset
    /// </summary>
    [JsonProperty("datasetUUID", NullValueHandling = NullValueHandling.Ignore)]
    public string DatasetUuid { get; set; }
}

/// <summary>
/// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host
/// machine and then exposed to the pod. More info:
/// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
///
/// Represents a Persistent Disk resource in Google Compute Engine.
///
/// A GCE PD must exist before mounting to a container. The disk must also be in the same GCE
/// project and zone as the kubelet. A GCE PD can only be mounted as read/write once or
/// read-only many times. GCE PDs support ownership management and SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1GcePersistentDiskVolumeSource
{
    /// <summary>
    /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem
    /// type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs".
    /// Implicitly inferred to be "ext4" if unspecified. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// The partition in the volume that you want to mount. If omitted, the default is to mount
    /// by volume name. Examples: For volume /dev/sda1, you specify the partition as "1".
    /// Similarly, the volume partition for /dev/sda is "0" (or you can leave the property
    /// empty). More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
    /// </summary>
    [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
    public long? Partition { get; set; }

    /// <summary>
    /// Unique name of the PD resource in GCE. Used to identify the disk in GCE. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
    /// </summary>
    [JsonProperty("pdName")]
    public string PdName { get; set; }

    /// <summary>
    /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More
    /// info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }
}

/// <summary>
/// GitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is
/// deprecated. To provision a container with a git repo, mount an EmptyDir into an
/// InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's
/// container.
///
/// Represents a volume that is populated with the contents of a git repository. Git repo
/// volumes do not support ownership management. Git repo volumes support SELinux
/// relabeling.
///
/// DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an
/// EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir
/// into the Pod's container.
/// </summary>
public partial class IoK8SApiCoreV1GitRepoVolumeSource
{
    /// <summary>
    /// Target directory name. Must not contain or start with '..'.  If '.' is supplied, the
    /// volume directory will be the git repository.  Otherwise, if specified, the volume will
    /// contain the git repository in the subdirectory with the given name.
    /// </summary>
    [JsonProperty("directory", NullValueHandling = NullValueHandling.Ignore)]
    public string Directory { get; set; }

    /// <summary>
    /// Repository URL
    /// </summary>
    [JsonProperty("repository")]
    public string Repository { get; set; }

    /// <summary>
    /// Commit hash for the specified revision.
    /// </summary>
    [JsonProperty("revision", NullValueHandling = NullValueHandling.Ignore)]
    public string Revision { get; set; }
}

/// <summary>
/// Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More
/// info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
///
/// Represents a Glusterfs mount that lasts the lifetime of a pod. Glusterfs volumes do not
/// support ownership management or SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1GlusterfsVolumeSource
{
    /// <summary>
    /// EndpointsName is the endpoint name that details Glusterfs topology. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod
    /// </summary>
    [JsonProperty("endpoints")]
    public string Endpoints { get; set; }

    /// <summary>
    /// Path is the Glusterfs volume path. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; }

    /// <summary>
    /// ReadOnly here will force the Glusterfs volume to be mounted with read-only permissions.
    /// Defaults to false. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }
}

/// <summary>
/// HostPath represents a pre-existing file or directory on the host machine that is directly
/// exposed to the container. This is generally used for system agents or other privileged
/// things that are allowed to see the host machine. Most containers will NOT need this. More
/// info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
///
/// Represents a host path mapped into a pod. Host path volumes do not support ownership
/// management or SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1HostPathVolumeSource
{
    /// <summary>
    /// Path of the directory on the host. If the path is a symlink, it will follow the link to
    /// the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; }

    /// <summary>
    /// Type for HostPath Volume Defaults to "" More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }
}

/// <summary>
/// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and
/// then exposed to the pod. More info:
/// https://releases.k8s.io/HEAD/examples/volumes/iscsi/README.md
///
/// Represents an ISCSI disk. ISCSI volumes can only be mounted as read/write once. ISCSI
/// volumes support ownership management and SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1IscsiVolumeSource
{
    /// <summary>
    /// whether support iSCSI Discovery CHAP authentication
    /// </summary>
    [JsonProperty("chapAuthDiscovery", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ChapAuthDiscovery { get; set; }

    /// <summary>
    /// whether support iSCSI Session CHAP authentication
    /// </summary>
    [JsonProperty("chapAuthSession", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ChapAuthSession { get; set; }

    /// <summary>
    /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem
    /// type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs".
    /// Implicitly inferred to be "ext4" if unspecified. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#iscsi
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// Custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface
    /// simultaneously, new iSCSI interface <target portal>:<volume name> will be created for the
    /// connection.
    /// </summary>
    [JsonProperty("initiatorName", NullValueHandling = NullValueHandling.Ignore)]
    public string InitiatorName { get; set; }

    /// <summary>
    /// Target iSCSI Qualified Name.
    /// </summary>
    [JsonProperty("iqn")]
    public string Iqn { get; set; }

    /// <summary>
    /// iSCSI Interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).
    /// </summary>
    [JsonProperty("iscsiInterface", NullValueHandling = NullValueHandling.Ignore)]
    public string IscsiInterface { get; set; }

    /// <summary>
    /// iSCSI Target Lun number.
    /// </summary>
    [JsonProperty("lun")]
    public long Lun { get; set; }

    /// <summary>
    /// iSCSI Target Portal List. The portal is either an IP or ip_addr:port if the port is other
    /// than default (typically TCP ports 860 and 3260).
    /// </summary>
    [JsonProperty("portals", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Portals { get; set; }

    /// <summary>
    /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// CHAP Secret for iSCSI target and initiator authentication
    /// </summary>
    [JsonProperty("secretRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1LocalObjectReference SecretRef { get; set; }

    /// <summary>
    /// iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than
    /// default (typically TCP ports 860 and 3260).
    /// </summary>
    [JsonProperty("targetPortal")]
    public string TargetPortal { get; set; }
}

/// <summary>
/// NFS represents an NFS mount on the host that shares a pod's lifetime More info:
/// https://kubernetes.io/docs/concepts/storage/volumes#nfs
///
/// Represents an NFS mount that lasts the lifetime of a pod. NFS volumes do not support
/// ownership management or SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1NfsVolumeSource
{
    /// <summary>
    /// Path that is exported by the NFS server. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#nfs
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; }

    /// <summary>
    /// ReadOnly here will force the NFS export to be mounted with read-only permissions.
    /// Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Server is the hostname or IP address of the NFS server. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#nfs
    /// </summary>
    [JsonProperty("server")]
    public string Server { get; set; }
}

/// <summary>
/// PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in
/// the same namespace. More info:
/// https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
///
/// PersistentVolumeClaimVolumeSource references the user's PVC in the same namespace. This
/// volume finds the bound PV and mounts that volume for the pod. A
/// PersistentVolumeClaimVolumeSource is, essentially, a wrapper around another type of
/// volume that is owned by someone else (the system).
/// </summary>
public partial class IoK8SApiCoreV1PersistentVolumeClaimVolumeSource
{
    /// <summary>
    /// ClaimName is the name of a PersistentVolumeClaim in the same namespace as the pod using
    /// this volume. More info:
    /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
    /// </summary>
    [JsonProperty("claimName")]
    public string ClaimName { get; set; }

    /// <summary>
    /// Will force the ReadOnly setting in VolumeMounts. Default false.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }
}

/// <summary>
/// PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted
/// on kubelets host machine
///
/// Represents a Photon Controller persistent disk resource.
/// </summary>
public partial class IoK8SApiCoreV1PhotonPersistentDiskVolumeSource
{
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating
    /// system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// ID that identifies Photon Controller persistent disk
    /// </summary>
    [JsonProperty("pdID")]
    public string PdId { get; set; }
}

/// <summary>
/// PortworxVolume represents a portworx volume attached and mounted on kubelets host
/// machine
///
/// PortworxVolumeSource represents a Portworx volume resource.
/// </summary>
public partial class IoK8SApiCoreV1PortworxVolumeSource
{
    /// <summary>
    /// FSType represents the filesystem type to mount Must be a filesystem type supported by the
    /// host operating system. Ex. "ext4", "xfs". Implicitly inferred to be "ext4" if unspecified.
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in
    /// VolumeMounts.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// VolumeID uniquely identifies a Portworx volume
    /// </summary>
    [JsonProperty("volumeID")]
    public string VolumeId { get; set; }
}

/// <summary>
/// Items for all in one resources secrets, configmaps, and downward API
///
/// Represents a projected volume source
/// </summary>
public partial class IoK8SApiCoreV1ProjectedVolumeSource
{
    /// <summary>
    /// Mode bits to use on created files by default. Must be a value between 0 and 0777.
    /// Directories within the path are not affected by this setting. This might be in conflict
    /// with other options that affect the file mode, like fsGroup, and the result can be other
    /// mode bits set.
    /// </summary>
    [JsonProperty("defaultMode", NullValueHandling = NullValueHandling.Ignore)]
    public long? DefaultMode { get; set; }

    /// <summary>
    /// list of volume projections
    /// </summary>
    [JsonProperty("sources")]
    public IoK8SApiCoreV1VolumeProjection[] Sources { get; set; }
}

/// <summary>
/// Projection that may be projected along with other supported volume types
/// </summary>
public partial class IoK8SApiCoreV1VolumeProjection
{
    /// <summary>
    /// information about the configMap data to project
    /// </summary>
    [JsonProperty("configMap", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ConfigMapProjection ConfigMap { get; set; }

    /// <summary>
    /// information about the downwardAPI data to project
    /// </summary>
    [JsonProperty("downwardAPI", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1DownwardApiProjection DownwardApi { get; set; }

    /// <summary>
    /// information about the secret data to project
    /// </summary>
    [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1SecretProjection Secret { get; set; }

    /// <summary>
    /// information about the serviceAccountToken data to project
    /// </summary>
    [JsonProperty("serviceAccountToken", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1ServiceAccountTokenProjection ServiceAccountToken { get; set; }
}

/// <summary>
/// information about the configMap data to project
///
/// Adapts a ConfigMap into a projected volume.
///
/// The contents of the target ConfigMap's Data field will be presented in a projected volume
/// as files using the keys in the Data field as the file names, unless the items element is
/// populated with specific mappings of keys to paths. Note that this is identical to a
/// configmap volume source without the default mode.
/// </summary>
public partial class IoK8SApiCoreV1ConfigMapProjection
{
    /// <summary>
    /// If unspecified, each key-value pair in the Data field of the referenced ConfigMap will be
    /// projected into the volume as a file whose name is the key and content is the value. If
    /// specified, the listed keys will be projected into the specified paths, and unlisted keys
    /// will not be present. If a key is specified which is not present in the ConfigMap, the
    /// volume setup will error unless it is marked optional. Paths must be relative and may not
    /// contain the '..' path or start with '..'.
    /// </summary>
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1KeyToPath[] Items { get; set; }

    /// <summary>
    /// Name of the referent. More info:
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Specify whether the ConfigMap or it's keys must be defined
    /// </summary>
    [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; }
}

/// <summary>
/// information about the downwardAPI data to project
///
/// Represents downward API info for projecting into a projected volume. Note that this is
/// identical to a downwardAPI volume source without the default mode.
/// </summary>
public partial class IoK8SApiCoreV1DownwardApiProjection
{
    /// <summary>
    /// Items is a list of DownwardAPIVolume file
    /// </summary>
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1DownwardApiVolumeFile[] Items { get; set; }
}

/// <summary>
/// information about the secret data to project
///
/// Adapts a secret into a projected volume.
///
/// The contents of the target Secret's Data field will be presented in a projected volume as
/// files using the keys in the Data field as the file names. Note that this is identical to
/// a secret volume source without the default mode.
/// </summary>
public partial class IoK8SApiCoreV1SecretProjection
{
    /// <summary>
    /// If unspecified, each key-value pair in the Data field of the referenced Secret will be
    /// projected into the volume as a file whose name is the key and content is the value. If
    /// specified, the listed keys will be projected into the specified paths, and unlisted keys
    /// will not be present. If a key is specified which is not present in the Secret, the volume
    /// setup will error unless it is marked optional. Paths must be relative and may not contain
    /// the '..' path or start with '..'.
    /// </summary>
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1KeyToPath[] Items { get; set; }

    /// <summary>
    /// Name of the referent. More info:
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Specify whether the Secret or its key must be defined
    /// </summary>
    [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; }
}

/// <summary>
/// information about the serviceAccountToken data to project
///
/// ServiceAccountTokenProjection represents a projected service account token volume. This
/// projection can be used to insert a service account token into the pods runtime filesystem
/// for use against APIs (Kubernetes API Server or otherwise).
/// </summary>
public partial class IoK8SApiCoreV1ServiceAccountTokenProjection
{
    /// <summary>
    /// Audience is the intended audience of the token. A recipient of a token must identify
    /// itself with an identifier specified in the audience of the token, and otherwise should
    /// reject the token. The audience defaults to the identifier of the apiserver.
    /// </summary>
    [JsonProperty("audience", NullValueHandling = NullValueHandling.Ignore)]
    public string Audience { get; set; }

    /// <summary>
    /// ExpirationSeconds is the requested duration of validity of the service account token. As
    /// the token approaches expiration, the kubelet volume plugin will proactively rotate the
    /// service account token. The kubelet will start trying to rotate the token if the token is
    /// older than 80 percent of its time to live or if the token is older than 24 hours.Defaults
    /// to 1 hour and must be at least 10 minutes.
    /// </summary>
    [JsonProperty("expirationSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public long? ExpirationSeconds { get; set; }

    /// <summary>
    /// Path is the path relative to the mount point of the file to project the token into.
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; }
}

/// <summary>
/// Quobyte represents a Quobyte mount on the host that shares a pod's lifetime
///
/// Represents a Quobyte mount that lasts the lifetime of a pod. Quobyte volumes do not
/// support ownership management or SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1QuobyteVolumeSource
{
    /// <summary>
    /// Group to map volume access to Default is no group
    /// </summary>
    [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
    public string Group { get; set; }

    /// <summary>
    /// ReadOnly here will force the Quobyte volume to be mounted with read-only permissions.
    /// Defaults to false.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Registry represents a single or multiple Quobyte Registry services specified as a string
    /// as host:port pair (multiple entries are separated with commas) which acts as the central
    /// registry for volumes
    /// </summary>
    [JsonProperty("registry")]
    public string Registry { get; set; }

    /// <summary>
    /// Tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned
    /// Quobyte volumes, value is set by the plugin
    /// </summary>
    [JsonProperty("tenant", NullValueHandling = NullValueHandling.Ignore)]
    public string Tenant { get; set; }

    /// <summary>
    /// User to map volume access to Defaults to serivceaccount user
    /// </summary>
    [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
    public string User { get; set; }

    /// <summary>
    /// Volume is a string that references an already created Quobyte volume by name.
    /// </summary>
    [JsonProperty("volume")]
    public string Volume { get; set; }
}

/// <summary>
/// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More
/// info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md
///
/// Represents a Rados Block Device mount that lasts the lifetime of a pod. RBD volumes
/// support ownership management and SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1RbdVolumeSource
{
    /// <summary>
    /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem
    /// type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs".
    /// Implicitly inferred to be "ext4" if unspecified. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#rbd
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// The rados image name. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("image")]
    public string Image { get; set; }

    /// <summary>
    /// Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("keyring", NullValueHandling = NullValueHandling.Ignore)]
    public string Keyring { get; set; }

    /// <summary>
    /// A collection of Ceph monitors. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("monitors")]
    public string[] Monitors { get; set; }

    /// <summary>
    /// The rados pool name. Default is rbd. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("pool", NullValueHandling = NullValueHandling.Ignore)]
    public string Pool { get; set; }

    /// <summary>
    /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More
    /// info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// SecretRef is name of the authentication secret for RBDUser. If provided overrides
    /// keyring. Default is nil. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("secretRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1LocalObjectReference SecretRef { get; set; }

    /// <summary>
    /// The rados user name. Default is admin. More info:
    /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
    /// </summary>
    [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
    public string User { get; set; }
}

/// <summary>
/// ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
///
/// ScaleIOVolumeSource represents a persistent ScaleIO volume
/// </summary>
public partial class IoK8SApiCoreV1ScaleIoVolumeSource
{
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating
    /// system. Ex. "ext4", "xfs", "ntfs". Default is "xfs".
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// The host address of the ScaleIO API Gateway.
    /// </summary>
    [JsonProperty("gateway")]
    public string Gateway { get; set; }

    /// <summary>
    /// The name of the ScaleIO Protection Domain for the configured storage.
    /// </summary>
    [JsonProperty("protectionDomain", NullValueHandling = NullValueHandling.Ignore)]
    public string ProtectionDomain { get; set; }

    /// <summary>
    /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in
    /// VolumeMounts.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// SecretRef references to the secret for ScaleIO user and other sensitive information. If
    /// this is not provided, Login operation will fail.
    /// </summary>
    [JsonProperty("secretRef")]
    public IoK8SApiCoreV1LocalObjectReference SecretRef { get; set; }

    /// <summary>
    /// Flag to enable/disable SSL communication with Gateway, default false
    /// </summary>
    [JsonProperty("sslEnabled", NullValueHandling = NullValueHandling.Ignore)]
    public bool? SslEnabled { get; set; }

    /// <summary>
    /// Indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned.
    /// Default is ThinProvisioned.
    /// </summary>
    [JsonProperty("storageMode", NullValueHandling = NullValueHandling.Ignore)]
    public string StorageMode { get; set; }

    /// <summary>
    /// The ScaleIO Storage Pool associated with the protection domain.
    /// </summary>
    [JsonProperty("storagePool", NullValueHandling = NullValueHandling.Ignore)]
    public string StoragePool { get; set; }

    /// <summary>
    /// The name of the storage system as configured in ScaleIO.
    /// </summary>
    [JsonProperty("system")]
    public string System { get; set; }

    /// <summary>
    /// The name of a volume already created in the ScaleIO system that is associated with this
    /// volume source.
    /// </summary>
    [JsonProperty("volumeName", NullValueHandling = NullValueHandling.Ignore)]
    public string VolumeName { get; set; }
}

/// <summary>
/// Secret represents a secret that should populate this volume. More info:
/// https://kubernetes.io/docs/concepts/storage/volumes#secret
///
/// Adapts a Secret into a volume.
///
/// The contents of the target Secret's Data field will be presented in a volume as files
/// using the keys in the Data field as the file names. Secret volumes support ownership
/// management and SELinux relabeling.
/// </summary>
public partial class IoK8SApiCoreV1SecretVolumeSource
{
    /// <summary>
    /// Optional: mode bits to use on created files by default. Must be a value between 0 and
    /// 0777. Defaults to 0644. Directories within the path are not affected by this setting.
    /// This might be in conflict with other options that affect the file mode, like fsGroup, and
    /// the result can be other mode bits set.
    /// </summary>
    [JsonProperty("defaultMode", NullValueHandling = NullValueHandling.Ignore)]
    public long? DefaultMode { get; set; }

    /// <summary>
    /// If unspecified, each key-value pair in the Data field of the referenced Secret will be
    /// projected into the volume as a file whose name is the key and content is the value. If
    /// specified, the listed keys will be projected into the specified paths, and unlisted keys
    /// will not be present. If a key is specified which is not present in the Secret, the volume
    /// setup will error unless it is marked optional. Paths must be relative and may not contain
    /// the '..' path or start with '..'.
    /// </summary>
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1KeyToPath[] Items { get; set; }

    /// <summary>
    /// Specify whether the Secret or it's keys must be defined
    /// </summary>
    [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; }

    /// <summary>
    /// Name of the secret in the pod's namespace to use. More info:
    /// https://kubernetes.io/docs/concepts/storage/volumes#secret
    /// </summary>
    [JsonProperty("secretName", NullValueHandling = NullValueHandling.Ignore)]
    public string SecretName { get; set; }
}

/// <summary>
/// StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.
///
/// Represents a StorageOS persistent volume resource.
/// </summary>
public partial class IoK8SApiCoreV1StorageOsVolumeSource
{
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating
    /// system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in
    /// VolumeMounts.
    /// </summary>
    [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// SecretRef specifies the secret to use for obtaining the StorageOS API credentials.  If
    /// not specified, default values will be attempted.
    /// </summary>
    [JsonProperty("secretRef", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiCoreV1LocalObjectReference SecretRef { get; set; }

    /// <summary>
    /// VolumeName is the human-readable name of the StorageOS volume.  Volume names are only
    /// unique within a namespace.
    /// </summary>
    [JsonProperty("volumeName", NullValueHandling = NullValueHandling.Ignore)]
    public string VolumeName { get; set; }

    /// <summary>
    /// VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is
    /// specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping
    /// to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to
    /// override the default behaviour. Set to "default" if you are not using namespaces within
    /// StorageOS. Namespaces that do not pre-exist within StorageOS will be created.
    /// </summary>
    [JsonProperty("volumeNamespace", NullValueHandling = NullValueHandling.Ignore)]
    public string VolumeNamespace { get; set; }
}

/// <summary>
/// VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
///
/// Represents a vSphere volume resource.
/// </summary>
public partial class IoK8SApiCoreV1VsphereVirtualDiskVolumeSource
{
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating
    /// system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
    /// </summary>
    [JsonProperty("fsType", NullValueHandling = NullValueHandling.Ignore)]
    public string FsType { get; set; }

    /// <summary>
    /// Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.
    /// </summary>
    [JsonProperty("storagePolicyID", NullValueHandling = NullValueHandling.Ignore)]
    public string StoragePolicyId { get; set; }

    /// <summary>
    /// Storage Policy Based Management (SPBM) profile name.
    /// </summary>
    [JsonProperty("storagePolicyName", NullValueHandling = NullValueHandling.Ignore)]
    public string StoragePolicyName { get; set; }

    /// <summary>
    /// Path that identifies vSphere volume vmdk
    /// </summary>
    [JsonProperty("volumePath")]
    public string VolumePath { get; set; }
}

/// <summary>
/// Most recently observed status of the Deployment.
///
/// DeploymentStatus is the most recently observed status of the Deployment.
/// </summary>
public partial class IoK8SApiAppsV1DeploymentStatus
{
    /// <summary>
    /// Total number of available pods (ready for at least minReadySeconds) targeted by this
    /// deployment.
    /// </summary>
    [JsonProperty("availableReplicas", NullValueHandling = NullValueHandling.Ignore)]
    public long? AvailableReplicas { get; set; }

    /// <summary>
    /// Count of hash collisions for the Deployment. The Deployment controller uses this field as
    /// a collision avoidance mechanism when it needs to create the name for the newest
    /// ReplicaSet.
    /// </summary>
    [JsonProperty("collisionCount", NullValueHandling = NullValueHandling.Ignore)]
    public long? CollisionCount { get; set; }

    /// <summary>
    /// Represents the latest available observations of a deployment's current state.
    /// </summary>
    [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
    public IoK8SApiAppsV1DeploymentCondition[] Conditions { get; set; }

    /// <summary>
    /// The generation observed by the deployment controller.
    /// </summary>
    [JsonProperty("observedGeneration", NullValueHandling = NullValueHandling.Ignore)]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Total number of ready pods targeted by this deployment.
    /// </summary>
    [JsonProperty("readyReplicas", NullValueHandling = NullValueHandling.Ignore)]
    public long? ReadyReplicas { get; set; }

    /// <summary>
    /// Total number of non-terminated pods targeted by this deployment (their labels match the
    /// selector).
    /// </summary>
    [JsonProperty("replicas", NullValueHandling = NullValueHandling.Ignore)]
    public long? Replicas { get; set; }

    /// <summary>
    /// Total number of unavailable pods targeted by this deployment. This is the total number of
    /// pods that are still required for the deployment to have 100% available capacity. They may
    /// either be pods that are running but not yet available or pods that still have not been
    /// created.
    /// </summary>
    [JsonProperty("unavailableReplicas", NullValueHandling = NullValueHandling.Ignore)]
    public long? UnavailableReplicas { get; set; }

    /// <summary>
    /// Total number of non-terminated pods targeted by this deployment that have the desired
    /// template spec.
    /// </summary>
    [JsonProperty("updatedReplicas", NullValueHandling = NullValueHandling.Ignore)]
    public long? UpdatedReplicas { get; set; }
}

/// <summary>
/// DeploymentCondition describes the state of a deployment at a certain point.
/// </summary>
public partial class IoK8SApiAppsV1DeploymentCondition
{
    /// <summary>
    /// Last time the condition transitioned from one status to another.
    /// </summary>
    [JsonProperty("lastTransitionTime", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastTransitionTime { get; set; }

    /// <summary>
    /// The last time this condition was updated.
    /// </summary>
    [JsonProperty("lastUpdateTime", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastUpdateTime { get; set; }

    /// <summary>
    /// A human readable message indicating details about the transition.
    /// </summary>
    [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
    public string Message { get; set; }

    /// <summary>
    /// The reason for the condition's last transition.
    /// </summary>
    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string Reason { get; set; }

    /// <summary>
    /// Status of the condition, one of True, False, Unknown.
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; }

    /// <summary>
    /// Type of deployment condition.
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }
}

/// <summary>
/// APIVersion defines the versioned schema of this representation of an object. Servers
/// should convert recognized schemas to the latest internal value, and may reject
/// unrecognized values. More info:
/// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
/// </summary>
public enum ApiVersion { AppsV1 };

/// <summary>
/// Kind is a string value representing the REST resource this object represents. Servers may
/// infer this from the endpoint the client submits requests to. Cannot be updated. In
/// CamelCase. More info:
/// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
/// </summary>
public enum DockerScriptKubernetesDataKind { Deployment };

/// <summary>
/// Kind is a string value representing the REST resource this object represents. Servers may
/// infer this from the endpoint the client submits requests to. Cannot be updated. In
/// CamelCase. More info:
/// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
/// </summary>
public enum ResultKind { Status };

/// <summary>
/// The maximum number of pods that can be scheduled above the desired number of pods. Value
/// can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). This can not
/// be 0 if MaxUnavailable is 0. Absolute number is calculated from percentage by rounding
/// up. Defaults to 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled
/// up immediately when the rolling update starts, such that the total number of old and new
/// pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet
/// can be scaled up further, ensuring that total number of pods running at any time during
/// the update is at most 130% of desired pods.
///
/// The maximum number of pods that can be unavailable during the update. Value can be an
/// absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is
/// calculated from percentage by rounding down. This can not be 0 if MaxSurge is 0. Defaults
/// to 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of
/// desired pods immediately when the rolling update starts. Once new pods are ready, old
/// ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet,
/// ensuring that the total number of pods available at all times during the update is at
/// least 70% of desired pods.
///
/// Name or number of the port to access on the container. Number must be in the range 1 to
/// 65535. Name must be an IANA_SVC_NAME.
///
/// Number or name of the port to access on the container. Number must be in the range 1 to
/// 65535. Name must be an IANA_SVC_NAME.
/// </summary>
public partial struct IoK8SApimachineryPkgUtilIntstrIntOrString
{
    public long? Integer;
    public string String;

    public static implicit operator IoK8SApimachineryPkgUtilIntstrIntOrString(long Integer) => new IoK8SApimachineryPkgUtilIntstrIntOrString { Integer = Integer };
    public static implicit operator IoK8SApimachineryPkgUtilIntstrIntOrString(string String) => new IoK8SApimachineryPkgUtilIntstrIntOrString { String = String };
}

/// <summary>
/// Specifies the output format of the exposed resources, defaults to "1"
///
/// Total amount of local storage required for this EmptyDir volume. The size limit is also
/// applicable for memory medium. The maximum usage on memory medium EmptyDir would be the
/// minimum value between the SizeLimit specified here and the sum of memory limits of all
/// containers in a pod. The default is nil which means that the limit is undefined. More
/// info: http://kubernetes.io/docs/user-guide/volumes#emptydir
/// </summary>
public partial struct IoK8SApimachineryPkgApiResourceQuantity
{
    public double? Double;
    public string String;

    public static implicit operator IoK8SApimachineryPkgApiResourceQuantity(double Double) => new IoK8SApimachineryPkgApiResourceQuantity { Double = Double };
    public static implicit operator IoK8SApimachineryPkgApiResourceQuantity(string String) => new IoK8SApimachineryPkgApiResourceQuantity { String = String };
}

internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            ApiVersionConverter.Singleton,
            DockerScriptKubernetesDataKindConverter.Singleton,
            ResultKindConverter.Singleton,
            IoK8SApimachineryPkgUtilIntstrIntOrStringConverter.Singleton,
            IoK8SApimachineryPkgApiResourceQuantityConverter.Singleton,
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
    };
}

internal class ApiVersionConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(ApiVersion) || t == typeof(ApiVersion?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "apps/v1")
        {
            return ApiVersion.AppsV1;
        }
        throw new Exception("Cannot unmarshal type ApiVersion");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (ApiVersion)untypedValue;
        if (value == ApiVersion.AppsV1)
        {
            serializer.Serialize(writer, "apps/v1");
            return;
        }
        throw new Exception("Cannot marshal type ApiVersion");
    }

    public static readonly ApiVersionConverter Singleton = new ApiVersionConverter();
}

internal class DockerScriptKubernetesDataKindConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(DockerScriptKubernetesDataKind) || t == typeof(DockerScriptKubernetesDataKind?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "Deployment")
        {
            return DockerScriptKubernetesDataKind.Deployment;
        }
        throw new Exception("Cannot unmarshal type DockerScriptKubernetesDataKind");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (DockerScriptKubernetesDataKind)untypedValue;
        if (value == DockerScriptKubernetesDataKind.Deployment)
        {
            serializer.Serialize(writer, "Deployment");
            return;
        }
        throw new Exception("Cannot marshal type DockerScriptKubernetesDataKind");
    }

    public static readonly DockerScriptKubernetesDataKindConverter Singleton = new DockerScriptKubernetesDataKindConverter();
}

internal class ResultKindConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(ResultKind) || t == typeof(ResultKind?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "Status")
        {
            return ResultKind.Status;
        }
        throw new Exception("Cannot unmarshal type ResultKind");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (ResultKind)untypedValue;
        if (value == ResultKind.Status)
        {
            serializer.Serialize(writer, "Status");
            return;
        }
        throw new Exception("Cannot marshal type ResultKind");
    }

    public static readonly ResultKindConverter Singleton = new ResultKindConverter();
}

internal class IoK8SApimachineryPkgUtilIntstrIntOrStringConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(IoK8SApimachineryPkgUtilIntstrIntOrString) || t == typeof(IoK8SApimachineryPkgUtilIntstrIntOrString?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        switch (reader.TokenType)
        {
            case JsonToken.Integer:
                var integerValue = serializer.Deserialize<long>(reader);
                return new IoK8SApimachineryPkgUtilIntstrIntOrString { Integer = integerValue };
            case JsonToken.String:
            case JsonToken.Date:
                var stringValue = serializer.Deserialize<string>(reader);
                return new IoK8SApimachineryPkgUtilIntstrIntOrString { String = stringValue };
        }
        throw new Exception("Cannot unmarshal type IoK8SApimachineryPkgUtilIntstrIntOrString");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        var value = (IoK8SApimachineryPkgUtilIntstrIntOrString)untypedValue;
        if (value.Integer != null)
        {
            serializer.Serialize(writer, value.Integer.Value);
            return;
        }
        if (value.String != null)
        {
            serializer.Serialize(writer, value.String);
            return;
        }
        throw new Exception("Cannot marshal type IoK8SApimachineryPkgUtilIntstrIntOrString");
    }

    public static readonly IoK8SApimachineryPkgUtilIntstrIntOrStringConverter Singleton = new IoK8SApimachineryPkgUtilIntstrIntOrStringConverter();
}

internal class IoK8SApimachineryPkgApiResourceQuantityConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(IoK8SApimachineryPkgApiResourceQuantity) || t == typeof(IoK8SApimachineryPkgApiResourceQuantity?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        switch (reader.TokenType)
        {
            case JsonToken.Integer:
            case JsonToken.Float:
                var doubleValue = serializer.Deserialize<double>(reader);
                return new IoK8SApimachineryPkgApiResourceQuantity { Double = doubleValue };
            case JsonToken.String:
            case JsonToken.Date:
                var stringValue = serializer.Deserialize<string>(reader);
                return new IoK8SApimachineryPkgApiResourceQuantity { String = stringValue };
        }
        throw new Exception("Cannot unmarshal type IoK8SApimachineryPkgApiResourceQuantity");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        var value = (IoK8SApimachineryPkgApiResourceQuantity)untypedValue;
        if (value.Double != null)
        {
            serializer.Serialize(writer, value.Double.Value);
            return;
        }
        if (value.String != null)
        {
            serializer.Serialize(writer, value.String);
            return;
        }
        throw new Exception("Cannot marshal type IoK8SApimachineryPkgApiResourceQuantity");
    }

    public static readonly IoK8SApimachineryPkgApiResourceQuantityConverter Singleton = new IoK8SApimachineryPkgApiResourceQuantityConverter();
}

