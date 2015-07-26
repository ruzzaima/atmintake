<?php
/* @var $this Ims_checklistController */
/* @var $model Checklist */

$this->breadcrumbs=array(
	'Checklists'=>array('index'),
	$model->Id=>array('view','id'=>$model->Id),
	'Update',
);

$this->menu=array(
	array('label'=>'List Checklist', 'url'=>array('index')),
	array('label'=>'Create Checklist', 'url'=>array('create')),
	array('label'=>'View Checklist', 'url'=>array('view', 'id'=>$model->Id))
);
?>

<h1>Update Checklist <?php echo $model->Id; ?></h1>

<?php $this->renderPartial('_form', array('model'=>$model)); ?>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
				xmlns:sevenhpk="http://www.dagangnet.com.my/"
        xmlns:sevenh="http://www.dagangnet.com.my/xsd/"
	xmlns:xs="http://www.w3.org/2001/XMLSchema">
	<xsl:output method="text" />
	<xsl:template match="xs:schema">
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Diagnostics;

    namespace DNext.CAMS.Domain
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
          [DataObject(true)]
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

            public <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/>
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

            public <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/>
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
        public <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/>
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
        public <xsl:value-of select="sevenhpk:GetCLRDataType(@type, @nillable)"/>
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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        <?php
/* @var $this Ims_endorsementController */
/* @var $model Endorsement */

$this->breadcrumbs=array(
	'Endorsements'=>array('index'),
	'Manage',
);

$this->menu=array(
	array('label'=>'List Endorsement', 'url'=>array('index')),
	array('label'=>'Create Endorsement', 'url'=>array('create')),
);

Yii::app()->clientScript->registerScript('search', "
$('.search-button').click(function(){
	$('.search-form').toggle();
	return false;
});
$('.search-form form').submit(function(){
	$('#endorsement-grid').yiiGridView('update', {
		data: $(this).serialize()
	});
	return false;
});
");
?>

<h1>Manage Endorsements</h1>

<p>
You may optionally enter a comparison operator (<b>&lt;</b>, <b>&lt;=</b>, <b>&gt;</b>, <b>&gt;=</b>, <b>&lt;&gt;</b>
or <b>=</b>) at the beginning of each of your search values to specify how the comparison should be done.
</p>

<?php echo CHtml::link('Advanced Search','#',array('class'=>'search-button')); ?>
<div class="search-form" style="display:none">
<?php $this->renderPartial('_search',array(
	'model'=>$model,
)); ?>
</div><!-- search-form -->

<?php $this->widget('zii.widgets.grid.CGridView', array(
	'id'=>'endorsement-grid',
	'dataProvider'=>$model->search(),
	'filter'=>$model,
	'columns'=>array(
		'endorsement_id',
		'policy_id',
		'policy_ref',
		'endorsement_ref',
		'endorsement_yr',
		'endorsement_startdate',
		/*
		'endorsement_enddate',
		'endorsement_customer_id',
		'endorsement_customer_name',
		'endorsement_desc',
		'endorsement_serial',
		'endorsement_productid',
		'endorsement_productcode',
		'endorsement_productdesc',
		'endorsement_limitofindemnity',
		'endorsement_grosspremium',
		'endorsement_adjgrosspremium',
		'endorsement_netpremium',
		'endorsement_excessclause',
		'endorsement_servicetax',
		'endorsement_stampduty',
		'endorsement_totalamt',
		'endorsement_status',
		'endorsement_createdby',
		'endorsement_createddate',
		'endorsement_modifiedby',
		'endorsement_modifieddate',
		*/
		array(
			'class'=>'CButtonColumn',
		),
	),
)); ?>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               