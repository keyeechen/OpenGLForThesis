#version 330 core
in vec2 TexCoord;
out vec4 FragColor;

uniform sampler2D texture1;
uniform sampler2D texture2;

void main() {
    //每一个纹素位置取80%的texture1的颜色，取20%纹素2的颜色
//    FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 1.0);
    FragColor = texture(texture2, TexCoord);
}
