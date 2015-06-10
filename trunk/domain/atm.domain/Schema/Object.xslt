<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
				xmlns:sevenhpk="http://www.dagangnet.com.my/"
        xmlns:sevenh="http://www.dagangnet.com.my/xsd/"
	xmlns:xs="http://www.w3.org/2001/XMLSchema">
	<xsl:output method="text" />
	<xsl:template match="xs:schema">
    using System;
    using System.Xml.Serialization;
    using System.Diagnostics;
    using System.Collections.Generic;

    namespace SevenH.MMCSB.Atm.Domain
    {
    <!-- ELEMENT -->
		<xsl:for-each select="xs:element">
			<xsl:choose>
				<!-- Complex TYPE -->
				<xsl:when test="@type">
				</xsl:when>
				<!-- ELEMENT -->
				<xsl:otherwise>
          ///&lt;summary&gt;
          /// <xsl:value-of select="xs:annotation/xs:documentation"/>
          ///&lt;/summary&gt;
          [Serializable]
					[XmlType("<xsl:value-of select="@name"/>",  Namespace=Strings.DefaultNamespace)]
					public <xsl:value-of select="@sevenh:inheritance"/> partial class <xsl:value-of select="@name"/>
					{

					<!-- attribute-->
					<xsl:for-each select="xs:complexType/xs:attribute">
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
						private  <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/> m_<xsl:value-of select="@name"/>;
						public const string PropertyName<xsl:value-of select="@name"/> = "<xsl:value-of select="@name"/>";
					</xsl:for-each>

					<!-- Element -->
					<xsl:for-each select="xs:complexType/xs:all/xs:element[@type != '']">
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]

						private <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/> m_<xsl:value-of select="@name"/>
						<xsl:if test="@sevenh:new='true'">
							=  new <xsl:value-of select="@type"/>()
						</xsl:if>;
						public const string PropertyName<xsl:value-of select="@name"/> = "<xsl:value-of select="@name"/>";
					</xsl:for-each>
					<xsl:apply-templates select="xs:complexType/xs:all/xs:element"/>
					<xsl:for-each select="xs:complexType/xs:attribute">
            ///&lt;summary&gt;
            /// <xsl:value-of select="xs:annotation/xs:documentation"/>
            ///&lt;/summary&gt;
						[XmlAttribute]
            [DebuggerHidden]

            public virtual <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/>
            <xsl:value-of select="@name"/>
						{
						set
						{
						if( <xsl:value-of select="sevenhpk:GetCLREqualitySymbol(@name, @type)"/>) return;
						var arg = new PropertyChangingEventArgs(PropertyName<xsl:value-of select="@name"/>, value);
						OnPropertyChanging(arg);
						if( !arg.Cancel)
						{
						m_<xsl:value-of select="@name"/>= value;
						OnPropertyChanged(PropertyName<xsl:value-of select="@name"/>);
						}
						}
						get
						{
						return m_<xsl:value-of select="@name"/>;}
						}
					</xsl:for-each>
					<xsl:for-each select="xs:complexType/xs:all/xs:element[@type != '']">

            ///&lt;summary&gt;
            /// <xsl:value-of select="xs:annotation/xs:documentation"/>
            ///&lt;/summary&gt;
            [DebuggerHidden]

            public virtual <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/>
            <xsl:value-of select="@name"/>
						{
						set
						{
						if(<xsl:value-of select="sevenhpk:GetCLREqualitySymbol(@name, @type)"/>) return;
						var arg = new PropertyChangingEventArgs(PropertyName<xsl:value-of select="@name"/>, value);
						OnPropertyChanging(arg);
						if(! arg.Cancel)
						{
						m_<xsl:value-of select="@name"/>= value;
						OnPropertyChanged(PropertyName<xsl:value-of select="@name"/>);
						}
						}
						get { return m_<xsl:value-of select="@name"/>;}
						}
					</xsl:for-each>


					}
				</xsl:otherwise>
			</xsl:choose>
		</xsl:for-each>
		<!-- COMPLEX TYPE -->
		<xsl:for-each select="xs:complexType">
			[XmlType("<xsl:value-of select="@name"/>",  Namespace=Strings.DefaultNamespace)]
			public partial class <xsl:value-of select="@name"/>
			{

			<!-- attribute-->
			<xsl:for-each select="xs:attribute">
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

				private  <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/> m_<xsl:value-of select="@name"/>;
				public const string PropertyName<xsl:value-of select="@name"/> = "<xsl:value-of select="@name"/>";
			</xsl:for-each>
			<!-- Element -->
			<xsl:for-each select="xs:all/xs:element[@type != '']">
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

				private <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/> m_<xsl:value-of select="@name"/>
				<xsl:if test="@sevenh:new='true'">
					=  new <xsl:value-of select="@type"/>()
				</xsl:if>;
				public const string PropertyName<xsl:value-of select="@name"/> = "<xsl:value-of select="@name"/>";
			</xsl:for-each>
			<xsl:apply-templates select="xs:all/xs:element"/>

			// public properties members
			<xsl:for-each select="xs:attribute">
				[XmlAttribute]
        public virtual <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/>
        <xsl:value-of select="@name"/>
				{
				set
				{
				if(m_<xsl:value-of select="@name"/>== value) return;
				var arg = new PropertyChangingEventArgs(PropertyName<xsl:value-of select="@name"/>, value);
				OnPropertyChanging(arg);
				if( !arg.Cancel)
				{
				m_<xsl:value-of select="@name"/>= value;
				OnPropertyChanged(PropertyName<xsl:value-of select="@name"/>);
				}
				}
				get
				{
				return m_<xsl:value-of select="@name"/>;}
				}
			</xsl:for-each>
			<xsl:for-each select="xs:all/xs:element[@type != '']">

        ///&lt;summary&gt;
        /// <xsl:value-of select="xs:annotation/xs:documentation"/>
        ///&lt;/summary&gt;
        public virtual <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/>
        <xsl:value-of select="@name"/>
				{
				set
				{
				if(m_<xsl:value-of select="@name"/>== value) return;
				var arg = new PropertyChangingEventArgs(PropertyName<xsl:value-of select="@name"/>, value);
				OnPropertyChanging(arg);
				if(! arg.Cancel)
				{
				m_<xsl:value-of select="@name"/>= value;
				OnPropertyChanged(PropertyName<xsl:value-of select="@name"/>);
				}
				}
				get { return m_<xsl:value-of select="@name"/>;}
				}
			</xsl:for-each>


			}

		</xsl:for-each>
		<!-- enum -->
		<xsl:for-each select="xs:simpleType">
			public enum <xsl:value-of select="@name"/>
			{
			<xsl:for-each select="xs:restriction/xs:enumeration">
				<xsl:value-of select="@value"/>,
			</xsl:for-each>}
		</xsl:for-each>
		}

	</xsl:template>
	<xsl:include href="ReferenceObject.xslt"/>
</xsl:stylesheet>
