#include <podofo/podofo.h>
#include <iostream>
#include <fstream>
#include <string>
#include <json/json.h>

using namespace PoDoFo;

extern "C" __declspec(dllexport) void ManipularPDF(const char* inputPdf, const char* outputPdf, const char* jsonFile, const char* backgroundImage) {
    try {
        // Carregar o PDF
        PdfMemDocument document(inputPdf);

        // Carregar o JSON
        std::ifstream jsonStream(jsonFile);
        Json::Value layouts;
        jsonStream >> layouts;

        // Iterar sobre as páginas do PDF
        for (int i = 0; i < document.GetPageCount(); ++i) {
            PdfPage* page = document.GetPage(i);

            // Adicionar imagem de fundo repetida
            PdfPainter painter;
            painter.SetPage(page);
            PdfImage image(&document);
            image.LoadFromFile(backgroundImage);

            double width = page->GetPageSize().GetWidth();
            double height = page->GetPageSize().GetHeight();
            painter.DrawImage(0, 0, &image, width, height);
            painter.FinishPage();

            // Adicionar nova página com base no layout
            PdfPage* newPage = document.CreatePage(PdfPage::CreateStandardPageSize(ePdfPageSize_A4));
            PdfPainter newPainter;
            newPainter.SetPage(newPage);

            // Exemplo: Adicionar texto do layout
            std::string layoutText = layouts["layout1"]["text"].asString();
            newPainter.DrawText(50, 800, layoutText.c_str());
            newPainter.FinishPage();
        }

        // Salvar o PDF modificado
        document.Write(outputPdf);
    }
    catch (PdfError& e) {
        std::cerr << "Erro ao manipular PDF: " << e.GetError() << std::endl;
    }
}
