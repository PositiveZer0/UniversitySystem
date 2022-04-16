using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversitySystem.Data.Migrations
{
    public partial class AddRequierments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Extension", "Name" },
                values: new object[] { "jpg", "AgrarenPU" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Extension", "Name" },
                values: new object[,]
                {
                    { 27, "png", "NHASO" },
                    { 28, "png", "NBUSO" },
                    { 29, "png", "PaisiiHilendarskiPU" },
                    { 30, "jpg", "RusenskiUniversitet" },
                    { 31, "png", "Sofiiski" },
                    { 32, "png", "StopanskaSvishtov" },
                    { 33, "png", "TUSO" },
                    { 34, "png", "TUVarna" },
                    { 26, "png", "NSASO" },
                    { 35, "png", "TUGAB" },
                    { 37, "png", "AsenZlatarovBurgas" },
                    { 38, "png", "UNSS" },
                    { 39, "png", "UASGSO" },
                    { 40, "jpg", "BITSO" },
                    { 41, "png", "UHTSO" },
                    { 42, "png", "HTMUSO" },
                    { 43, "png", "Shumen" },
                    { 44, "jpg", "UgozapadenBlagoevgrad" },
                    { 36, "jpg", "TrakiiskiUni" },
                    { 24, "png", "NATFIZSO" },
                    { 25, "jpg", "MuzikalnaAkadPanchoVladigerov" },
                    { 22, "jpg", "MinnoGeolojkiIvanRilski" },
                    { 3, "png", "AkademiqMVRSU" },
                    { 4, "png", "AUBG" },
                    { 5, "png", "BurgaskiSvobodenUni" },
                    { 6, "png", "VarnenskiSvobodenUniChernorizec" },
                    { 7, "png", "VTU" },
                    { 8, "png", "VoennomorskoUchilishteVaptsarov" },
                    { 9, "jpg", "VisheTransportnoKableshkov" },
                    { 10, "png", "VishteTransportnoPoAgrobiznesPu" },
                    { 23, "gif", "NVULevski" },
                    { 12, "png", "VPTIPoshtiSO" },
                    { 11, "png", "VPZIFinansiSO" },
                    { 14, "jpg", "EuKolejIkonomikaPU" },
                    { 15, "png", "IkonomicheskiVarna" },
                    { 16, "jpg", "KolejPoIkonomikaIAdministraciq" },
                    { 17, "jpg", "LesotehnicheskiSO" },
                    { 18, "jpg", "MUVarna" },
                    { 19, "jpg", "MUPleven" },
                    { 20, "png", "MUPlovdiv" },
                    { 21, "png", "MUSO" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Extension", "Name" },
                values: new object[,]
                {
                    { 13, "jpg", "VisheLubenKaravelovSO" },
                    { 2, "jpg", "AmtiiPU" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SpecialityId" },
                values: new object[,]
                {
                    { 4, "Втора оценка по избираем предмет", null },
                    { 1, "Матура по български език", null },
                    { 2, "Свободноизбираема матура", null },
                    { 3, "Оценка по български език", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Extension", "Name" },
                values: new object[] { "png", "HTMUSO" });
        }
    }
}
