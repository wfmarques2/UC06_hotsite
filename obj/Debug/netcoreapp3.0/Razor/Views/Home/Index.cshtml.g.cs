#pragma checksum "C:\Users\NOTE\Desktop\curso tecnico senac\Tecnico_Informatica_Senac-main\Modulo B\UC 06 - Publicar e Testar Aplicações Web\vynna19-SENAC---UC06---Atividades-main\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a668e0bc1e039d9fe59dc08ad462c54b6cd1b9a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\NOTE\Desktop\curso tecnico senac\Tecnico_Informatica_Senac-main\Modulo B\UC 06 - Publicar e Testar Aplicações Web\vynna19-SENAC---UC06---Atividades-main\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NOTE\Desktop\curso tecnico senac\Tecnico_Informatica_Senac-main\Modulo B\UC 06 - Publicar e Testar Aplicações Web\vynna19-SENAC---UC06---Atividades-main\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a668e0bc1e039d9fe59dc08ad462c54b6cd1b9a1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Interesse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\NOTE\Desktop\curso tecnico senac\Tecnico_Informatica_Senac-main\Modulo B\UC 06 - Publicar e Testar Aplicações Web\vynna19-SENAC---UC06---Atividades-main\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Iniciativa Saúde da Cidade";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Descrição-->
<div class=""col-6"">
    <h1>Iniciativa Saúde da Cidade</h1>
    <p>
        As facilidades e avanços proporcionados pela vida moderna trazem muitas vezes, como Indesejada contrapartida, alguns efeitos colaterais. Quem habita em centros urbanos é obrigado a Conviver com uma estressante rotina, marcada por congestionamentos, excesso de compromisso, falta De tempo para o lazer e para o convívio com familares e amigos.
Para fazer frente a essa realidade, é preciso reagir, tomar uma atitude para repor as energias, Restabelecer o equilíbrio físico e emocional; enfim, colocar a qualidade de vida em primeiro lugar.
A prática de atividade física é um meio eficaz para fortalecer o Organismo e manter condições de vida saudáveis, desde a prevenção de Doenças cardiovasculares, combate ao estresse e manter boas condições Do sistema musculoesquelético. Pessoas com excesso de peso sofrem dor Nas articulações, sobrecarregam vasos e com o tempo apresentam Dificuldade para se locomover e Fazer moviment");
            WriteLiteral(@"os básicos.
Portanto, mexa-se
    </p>
</div>

<!-- Imagem Maior-->
<div class=""col-6"" style='width: 500px; margin-top: 25px; display: flex; justify-content: space-between;'>
    <img src=""https://www.lizamayliza.com/storage/cache/images/004/118/Venice-Beach,xlarge.1480369578.jpg"" alt=""academia""
        style=""width: 600px; height: 380px;"">
</div>

<div class=""col-6"">
    <h2>Entre em contato!</h2>
    <p>Nos mande uma mensagem e fique por dentro de nossos eventos</p>
    
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a668e0bc1e039d9fe59dc08ad462c54b6cd1b9a16069", async() => {
                WriteLiteral(@"
                <div>
					<input placeholder=""*Nome"" type=""text"" name=""Nome"" required />
				</div><br>
        <div>
          <input placeholder=""*Email"" type=""text"" name=""Email"" required />
				</div><br>
        <div>
            <textarea placeholder=""Mensagem (não obrigatório)"" name=""Mensagem""></textarea>
				</div><br>
        <div>
            <input type=""submit"" value=""Enviar"" class=""btn btn-success""/>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    
</div>

<!-- Imagens e Referências-->
<div class=""col-6"" style='width: 500px; margin-top: 25px; display: flex; justify-content: space-between;'>
    <a data-toggle=""modal"" href=""#ModalAgenda"" style=""display: flex; flex-direction: column; align-items: center; font-size: 15px""><img
            src=""https://spnegocios.com/wp-content/themes/spnegocios/assets/img/default-events.png?x12705&t=1598926676"" alt=""calendario""
            style=""width: 100px; height: 100px;""> Agenda de Eventos</a>
    <a data-toggle=""modal"" href=""#ModalDicas"" style=""display: flex; flex-direction: column; align-items: center; font-size: 15px""><img
            src=""https://flyclipart.com/thumbs/fitness-lifestyle-clipart-logo-for-healthy-lifestyle-1251037.png""
            alt=""saudavel"" style=""width: 100px; height: 100px;""> Dicas de Vida Saudável</a>
    <a data-toggle=""modal"" href=""#ModalApoiadores"" style=""display: flex; flex-direction: column; align-items: center; font-size: 15px""><img
            src=""https://i0.wp.com/");
            WriteLiteral(@"jornalaw.com.br/wp-content/uploads/2016/07/patrocinadores.gif?fit=389%2C353&ssl=1"" alt=""apoiadores""
            style=""width: 100px; height: 100px;""> Apoiadores</a>
</div>



<!-- Modal Dicas -->
<div class=""modal fade"" id=""ModalDicas"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle""
    aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""ModalDicas"">Dicas de Vida Saudável</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>De acordo com informações do Ministério da Saúde, manter hábitos saudáveis diariamente é a melhor forma de prevenir doenças, você sabia? Manter a saúde em dia está diretamente ligada à sensação de felicidade e bem-esta");
            WriteLiteral(@"r. . 
Veja abaixo cinco dicas importantes para você adotar no dia a dia: 
                </p><br>
                <p>
                    1. Durma de 6 a 8 horas por dia
                </p>
                <p>
                    Dormir de 6 a 8 horas por dia é muito importante para que o corpo descanse e reponha as energias necessárias. É nesse período também que são liberados hormônios, como o cortisol e o GH. O cortisol é responsável pelo combate de algumas complicações, como as alergias, e o GH, responsável pelo crescimento e multiplicação celular
                </p><br>
                <p>
                    2. Alimente-se bem
                </p>
                <p>
                    Comer de 3 em 3 horas em pequenas quantidades, beber no mínimo 2 litros de água e fazer escolhas inteligentes no mercado são formas de manter uma dieta equilibrada diariamente. 
Prefira sempre pelos alimentos naturais, aqueles que contêm maior quantidade de vitaminas e fibras, como frutas, grãos, verdura");
            WriteLiteral(@"s e legumes. Alimentos com gorduras boas, como o azeite, também fazem bem para a saúde. 

                </p><br>
                <p>
                    3. Evite refrigerantes e bebidas alcoólicas
                </p>
                <p>
                    O consumo de refrigerantes não é indicado, pois eles contêm uma grande quantidade de açúcar em sua composição, o que é muito perigoso para a saúde do coração. 
Já o consumo de bebidas alcoólicas também deve ser evitado, só que em grandes quantidades. Para quem não sabe, beber cerca de 250 ml de vinho por noite faz bem para a saúde. Mas não abuse. Seu consumo exagerado pode provocar dependência e o surgimento de doenças graves, como a cirrose.

                </p><br>
                <p>4. Pratique atividades físicas</p>
                <p>Fazer academia ou praticar algum esporte de 2 a 3 vezes por semana é muito importante para controlar o peso e evitar doenças cardiovasculares. Atividade física também ajuda na saúde emocional do ser humano,");
            WriteLiteral(@" elevando o humor e afastando a ansiedade. </p><br>
                <p>5. Realize check-ups periodicamente</p>
                <p>Os check-ups são importantes para diagnosticar doenças silenciosas precocemente. O dr.consulta oferece vários tipos de exames de rotina para você e sua família manterem a saúde em dia. 
Agora que você já conhece todas as dicas, basta colocá-las em prática e ter uma vida mais saudável e feliz.
</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>

<!-- Modal Agenda -->
<div class=""modal fade"" id=""ModalAgenda"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle""
    aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""ModalAgenda"">Agenda</h5>
                <");
            WriteLiteral(@"button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>29/05/2022 - Eduardo Correa Classic.
A competição, que homenageia em seu nome o fisiculturista Eduardo Correa, acontece em Camboriú (Santa Catarina) no Maria´s Shows e Eventos.
As categorias serão  Bodybuilding, Classic Physique, Men’s Physique, Bikini, Wellness, Figure, Women’s Physique e Atletas Especiais.
Estarão presentes os nomes mais expressivos do universo bodybuilder do país, além de representantes de mais seis países: Argentina, Paraguai, Uruguai, Peru, França e Nigéria.

                </p>

                <p>10/07/2022 - A Maratona de Revezamento KTO é uma corrida Diurna. Será realizada em Porto Alegre, no Estado do Rio Grande do Sul, com participação de ambos os sexos. Terá percursos de 42km (Dupla, Quarteto e Octeto).
 Serão premiados com troféus e ");
            WriteLiteral(@"brindes os cinco primeiros colocados nas duplas (masculina, feminina e mista) quartetos ( masculino ,feminino e mista ) e Octeto( masculino, feminino e misto), não havendo premiação em dinheiro, nem premiação por faixa etária. 

                </p>


                <p>28/07/2022 - Para as pessoas da terceira idade, o fim de semana oferece uma série de eventos voltados para quem busca ter um estilo de vida mais saudável. Entre esta sexta-feira (28/7) e o próximo domingo (30/7), acontece a 2; edição da Feira da Longevidade, na área externa do Brasília Shopping. Profissionais e prestadores de serviço que atendem especificamente às pessoas da terceira idade estarão presente para tirar dúvidas.
                </p>


                
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>

<!-- Modal Apoiadores -->
<div class=""modal fade"" id");
            WriteLiteral(@"=""ModalApoiadores"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle""
    aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""ModalApoiadores"">Apoiadores</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <a style=""display: flex; flex-direction: column; align-items: center; font-size: 15px""><img
            src=""https://cf.shopee.com.br/file/b990c17d5dfce5943a0aec3d76568579"" alt=""calendario""
            style=""width: 120px; height: 120px;""> Integral Medica</a><br>

                <a style=""display: flex; flex-direction: column; align-items: center; font-size: 15px""><img
            src=""https://static.jackcenter.com.br/upload/brand/landerlan.j");
            WriteLiteral(@"pg"" alt=""calendario""
            style=""width: 120px; height: 120px;""> Landerlan</a><br>

                <a style=""display: flex; flex-direction: column; align-items: center; font-size: 15px""><img
            src=""https://yt3.ggpht.com/ytc/AKedOLRtJcBCy2ok9TQyIdz1Kwx3w9i48iDfz3x_9G5q8g=s900-c-k-c0x00ffffff-no-rj"" alt=""calendario""
            style=""width: 120px; height: 120px;""> Max Titanium</a><br>

                <a style=""display: flex; flex-direction: column; align-items: center; font-size: 15px""><img
            src=""https://www.suplementoszone.com.br/image/data/Imagem-Produtos/New-Millen/logo-new_millen.png"" alt=""calendario""
            style=""width: 120px; height: 120px;""> New Millen</a><br>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Interesse> Html { get; private set; }
    }
}
#pragma warning restore 1591
