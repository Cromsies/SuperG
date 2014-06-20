Shader "Custom/ColorMix" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
		
			half4 c = tex2D (_MainTex, IN.uv_MainTex);
			
			if (_CosTime.w < 0)
			{
				c.r = (1 - c.r) * abs(_CosTime.w);
				c.b = (1 - c.b) * abs(_CosTime.w);
				c.g = (1 - c.g) * abs(_CosTime.w);
				
			}
			else
			{
			c.r *= abs(_CosTime.w);
			c.b *= abs(_SinTime.w); //sin and costime are float 4 's !!! which is XYZW
			c.g *= abs(_CosTime.w);
			}
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}