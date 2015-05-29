<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:xs="http://www.w3.org/2001/XMLSchema"
  xmlns:ms="urn:schemas-microsoft-com:xslt"
  xmlns:sevenhpk="http://www.dagangnet.com.my/"
  xmlns:msxsl="urn:schemas-microsoft-com:xslt"
  xmlns:sevenh="http://www.dagangnet.com.my/xsd/">
  <xsl:template match="xs:element">
    <!-- Collection -->
    <xsl:for-each select="xs:complexType/xs:sequence/xs:element">
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private <xsl:value-of select="sevenhpk:RemovePrefixDataType(@ref, @maxOccurs)"/> m_<xsl:value-of select="sevenhpk:RemovePrefixMember(@ref, @maxOccurs)"/> = new <xsl:value-of select="sevenhpk:RemovePrefixDataTypeForNew(@ref, @maxOccurs)"/>();


      ///&lt;summary&gt;
      /// <xsl:value-of select="../../../xs:annotation/xs:documentation"/>
      ///&lt;/summary&gt;
      [XmlArrayItem("<xsl:value-of select="@ref"/>", IsNullable = false)]
		[DebuggerHidden]
		 
      public virtual <xsl:value-of select="sevenhpk:RemovePrefixDataType(@ref, @maxOccurs)"/> <xsl:value-of select="sevenhpk:RemovePrefixMember(@ref, @maxOccurs)"/>
      {
      get{ return m_<xsl:value-of select="sevenhpk:RemovePrefixMember(@ref, @maxOccurs)"/>;}
      }
    </xsl:for-each>

    <!-- 
      Just plain assocation 1 to 1 
    -->
    <xsl:if test="@ref">
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private <xsl:value-of select="@ref"/> m_<xsl:value-of select="@ref"/>
      <xsl:choose>
        <!-- when new is missing, always new them -->
        <xsl:when test="@sevenh:new='false'">;   </xsl:when>
        <xsl:otherwise>
          =  new <xsl:value-of select="@ref"/>();
        </xsl:otherwise>
      </xsl:choose>
      public const string PropertyName<xsl:value-of select="@ref"/> = "<xsl:value-of select="@ref"/>";
		[DebuggerHidden]

      public virtual <xsl:value-of select="@ref"/><xsl:text> </xsl:text> <xsl:value-of select="@ref"/>
      {
      get{ return m_<xsl:value-of select="@ref"/>;}
      set
      {
      m_<xsl:value-of select="@ref"/> = value;
      OnPropertyChanged(PropertyName<xsl:value-of select="@ref"/>);
      }
      }
    </xsl:if>

    <!-- 
      Element with simple restriction rules- for string and integer
      -->
    <xsl:if test="xs:simpleType">
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private <xsl:value-of select="sevenhpk:GetCLRDataType(xs:simpleType/xs:restriction/@base, xs:simpleType/xs:restriction/@nillable)"/> m_<xsl:value-of select="@name"/>;
      public const string PropertyName<xsl:value-of select="@name"/> = "<xsl:value-of select="@name"/>";

      public virtual <xsl:value-of select="sevenhpk:GetCLRDataType(xs:simpleType/xs:restriction/@base, xs:simpleType/xs:restriction/@nillable)"/> <xsl:value-of select="@name"/>
      {
      get { return m_<xsl:value-of select="@name"/>; }

      set
      {
      <xsl:if test="xs:simpleType/xs:restriction/@base = 'xs:string'">
        if(value.Length &lt; <xsl:value-of select="xs:simpleType/xs:restriction/xs:minLength/@value"/>)
        {
        SetColumnError( PropertyName<xsl:value-of select="@name"/>, "The length is less than <xsl:value-of select="xs:simpleType/xs:restriction/xs:minLength/@value"/>");
        return;
        }

        if( value.Length &gt; <xsl:value-of select="xs:simpleType/xs:restriction/xs:maxLength/@value"/>)
        {
        SetColumnError( PropertyName<xsl:value-of select="@name"/>, "The length is greater than <xsl:value-of select="xs:simpleType/xs:restriction/xs:maxLength/@value"/>");
        return;
        }
      </xsl:if>
      <xsl:if test="xs:simpleType/xs:restriction/@base = 'xs:int'">
        if(value &lt; <xsl:value-of select="xs:simpleType/xs:restriction/xs:minInclusive/@value"/>)
        {
        SetColumnError( PropertyName<xsl:value-of select="@name"/>,"The length is less than <xsl:value-of select="xs:simpleType/xs:restriction/xs:minInclusive/@value"/>");
        return;
        }
        if( value &gt; <xsl:value-of select="xs:simpleType/xs:restriction/xs:maxInclusive/@value"/>)
        {
        SetColumnError( PropertyName<xsl:value-of select="@name"/>,"The value is greater than <xsl:value-of select="xs:simpleType/xs:restriction/xs:maxInclusive/@value"/>");
        return;
        }
      </xsl:if>

      if(m_<xsl:value-of select="@name"/>== value) return;

      m_<xsl:value-of select="@name"/> = value;
      ClearColumnError(PropertyName<xsl:value-of select="@name"/>);
      OnPropertyChanged(PropertyName<xsl:value-of select="@name"/>);
      }
      }
    </xsl:if>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="sevenhpk">
    <![CDATA[
		public string RemovePrefixMember(string value, string maxOccur)
		{
			int max;
			string suffix = string.Empty;
			if( int.TryParse(maxOccur, out max))
			{
				if( max > 1) suffix = "Collection";
			}else
			{
				if( maxOccur == "unbounded") suffix = "Collection";
			}
			
			int indexOfColon = value.IndexOf(":") + 1;
			return value.Substring(indexOfColon, value.Length - indexOfColon) + suffix;
		}	
		public string RemovePrefixDataType(string value, string maxOccur)
		{
			int max ;
			string suffix = string.Empty;
			string prefix = string.Empty;
			if( int.TryParse(maxOccur, out max))
			{
				if( max > 1) 
				{	
					suffix = ">";
					prefix = "BindingList<";
				}
			}else
			{
				if( maxOccur == "unbounded")
				{	
					suffix = ">";
					prefix = "IList<";
				}
			}
			
			int indexOfColon = value.IndexOf(":") + 1;
			return prefix + value.Substring(indexOfColon, value.Length - indexOfColon) + suffix;
		}
		public string RemovePrefixDataTypeForNew(string value, string maxOccur)
		{
			int max ;
			string suffix = string.Empty;
			string prefix = string.Empty;
			if( int.TryParse(maxOccur, out max))
			{
				if( max > 1) 
				{	
					suffix = ">";
					prefix = "BindingList<";
				}
			}else
			{
				if( maxOccur == "unbounded")
				{	
					suffix = ">";
					prefix = "List<";
				}
			}
			
			int indexOfColon = value.IndexOf(":") + 1;
			return prefix + value.Substring(indexOfColon, value.Length - indexOfColon) + suffix;
		}
		
		public string GetCLRDataType(string xsType, bool nillable)
		{
			string type = "object";
			switch(xsType)
			{
				case "xs:string":
					type = "string";
					break;
				case "xs:date":
				case "xs:dateTime":
					type = "DateTime";
					break;
				case "xs:int":
					type = "int";
					break;
				case "xs:boolean":
					type = "bool";
					break;
				case "xs:float":
					type="float";
					break;
				case "xs:double":
					type = "double";
					break;
				case "xs:decimal":
					type = "decimal";
					break;
				case "State":
					type = "State";
					break;
				default:
					type = xsType;
					break;
			}
			if( nillable) type += "?";
			return type += " ";
		}
    
    
    public string GetCLREqualitySymbol(string name, string xsType)
		{
		
				if( String.Equals("xs:string", xsType, StringComparison.Ordinal))
        {
					return "String.Equals( m_" + name + ", value, StringComparison.Ordinal)";
          }
          return "m_"+name + " == value";
		
    
		}
	  ]]>

  </msxsl:script>
</xsl:stylesheet>