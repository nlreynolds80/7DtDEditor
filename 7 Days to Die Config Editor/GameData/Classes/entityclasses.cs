﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class property {
    
    private property[] property1Field;
    
    private string nameField;
    
    private string valueField;
    
    private string param1Field;
    
    private string classField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("property")]
    public property[] property1 {
        get {
            return this.property1Field;
        }
        set {
            this.property1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string param1 {
        get {
            return this.param1Field;
        }
        set {
            this.param1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @class {
        get {
            return this.classField;
        }
        set {
            this.classField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class entity_classes {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("entity_class", typeof(entity_classesEntity_class), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("property", typeof(property))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class entity_classesEntity_class {
    
    private property[] propertyField;
    
    private entity_classesEntity_classEffect_group[] effect_groupField;
    
    private entity_classesEntity_classDrop[] dropField;
    
    private string nameField;
    
    private string extendsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("property")]
    public property[] property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("effect_group", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public entity_classesEntity_classEffect_group[] effect_group {
        get {
            return this.effect_groupField;
        }
        set {
            this.effect_groupField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("drop", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public entity_classesEntity_classDrop[] drop {
        get {
            return this.dropField;
        }
        set {
            this.dropField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extends {
        get {
            return this.extendsField;
        }
        set {
            this.extendsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class entity_classesEntity_classEffect_group {
    
    private entity_classesEntity_classEffect_groupPassive_effect[] passive_effectField;
    
    private entity_classesEntity_classEffect_groupTriggered_effect[] triggered_effectField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("passive_effect", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public entity_classesEntity_classEffect_groupPassive_effect[] passive_effect {
        get {
            return this.passive_effectField;
        }
        set {
            this.passive_effectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("triggered_effect", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public entity_classesEntity_classEffect_groupTriggered_effect[] triggered_effect {
        get {
            return this.triggered_effectField;
        }
        set {
            this.triggered_effectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class entity_classesEntity_classEffect_groupPassive_effect {
    
    private string nameField;
    
    private string operationField;
    
    private string valueField;
    
    private string tagsField;
    
    private string match_all_tagsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string operation {
        get {
            return this.operationField;
        }
        set {
            this.operationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tags {
        get {
            return this.tagsField;
        }
        set {
            this.tagsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string match_all_tags {
        get {
            return this.match_all_tagsField;
        }
        set {
            this.match_all_tagsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class entity_classesEntity_classEffect_groupTriggered_effect {
    
    private entity_classesEntity_classEffect_groupTriggered_effectRequirement[] requirementField;
    
    private string triggerField;
    
    private string actionField;
    
    private string buffField;
    
    private string targetField;
    
    private string cvarField;
    
    private string operationField;
    
    private string valueField;
    
    private string eventField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("requirement", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public entity_classesEntity_classEffect_groupTriggered_effectRequirement[] requirement {
        get {
            return this.requirementField;
        }
        set {
            this.requirementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trigger {
        get {
            return this.triggerField;
        }
        set {
            this.triggerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string buff {
        get {
            return this.buffField;
        }
        set {
            this.buffField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string target {
        get {
            return this.targetField;
        }
        set {
            this.targetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cvar {
        get {
            return this.cvarField;
        }
        set {
            this.cvarField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string operation {
        get {
            return this.operationField;
        }
        set {
            this.operationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @event {
        get {
            return this.eventField;
        }
        set {
            this.eventField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class entity_classesEntity_classEffect_groupTriggered_effectRequirement {
    
    private string nameField;
    
    private string tagsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tags {
        get {
            return this.tagsField;
        }
        set {
            this.tagsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class entity_classesEntity_classDrop {
    
    private string eventField;
    
    private string nameField;
    
    private string countField;
    
    private string tool_categoryField;
    
    private string tagField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @event {
        get {
            return this.eventField;
        }
        set {
            this.eventField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string count {
        get {
            return this.countField;
        }
        set {
            this.countField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tool_category {
        get {
            return this.tool_categoryField;
        }
        set {
            this.tool_categoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tag {
        get {
            return this.tagField;
        }
        set {
            this.tagField = value;
        }
    }
}