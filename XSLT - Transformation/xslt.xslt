<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" exclude-result-prefixes="xsl" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" indent="yes" />
  <xsl:key name="group" match="item" use="@group" />
  <xsl:template match="list">
    <groups>
      <xsl:apply-templates select="item[generate-id(.) = generate-id(key('group',@group))]" />
    </groups>
  </xsl:template>
  <xsl:template match="item">
    <group name="{@group}">
      <xsl:for-each select="key('group',@group)">
        <item name="{@name}" />
      </xsl:for-each>
    </group>
  </xsl:template>
</xsl:stylesheet>