using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace practice.Migrations
{
    /// <inheritdoc />
    public partial class ComplexDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1045,
                column: "DepartmentID",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1050,
                column: "DepartmentID",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2021,
                column: "DepartmentID",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2042,
                column: "DepartmentID",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3141,
                column: "DepartmentID",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4022,
                column: "DepartmentID",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4041,
                column: "DepartmentID",
                value: -4);

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "ID", "FirstName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { -5, "Roger", new DateTime(2004, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zheng" },
                    { -4, "Candace", new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kapoor" },
                    { -3, "Roger", new DateTime(1998, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harui" },
                    { -2, "Fadi", new DateTime(2002, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fakhouri" },
                    { -1, "Kim", new DateTime(1995, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abercrombie" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "ID", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { -8, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nino", "Olivetto" },
                    { -7, new DateTime(2013, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Norman" },
                    { -6, new DateTime(2011, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peggy", "Justice" },
                    { -5, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yan", "Li" },
                    { -4, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gytis", "Barzdukas" },
                    { -3, new DateTime(2013, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arturo", "Anand" },
                    { -2, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meredith", "Alonso" },
                    { -1, new DateTime(2010, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carson", "Alexander" }
                });

            migrationBuilder.InsertData(
                table: "CourseAssignment",
                columns: new[] { "CourseID", "InstructorID" },
                values: new object[,]
                {
                    { 1045, -2 },
                    { 1050, -4 },
                    { 2021, -1 },
                    { 2042, -1 },
                    { 3141, -3 },
                    { 4022, -5 },
                    { 4041, -5 }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "Budget", "InstructorID", "Name", "StartDate" },
                values: new object[,]
                {
                    { -4, 100000m, -4, "Economics", new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -3, 350000m, -3, "Engineering", new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -2, 100000m, -2, "Mathematics", new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -1, 350000m, -1, "English", new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentID", "CourseID", "Grade", "StudentID" },
                values: new object[,]
                {
                    { -11, 2042, 1, -6 },
                    { -10, 2021, 1, -5 },
                    { -9, 1050, 1, -4 },
                    { -8, 4022, 1, -3 },
                    { -7, 1050, null, -3 },
                    { -6, 2021, 1, -2 },
                    { -5, 3141, 1, -2 },
                    { -4, 1045, 1, -2 },
                    { -3, 4041, 1, -1 },
                    { -2, 4022, 2, -1 },
                    { -1, 1050, 0, -1 }
                });

            migrationBuilder.InsertData(
                table: "OfficeAssignment",
                columns: new[] { "InstructorID", "Location" },
                values: new object[,]
                {
                    { -4, "Thompson 304" },
                    { -3, "Gowan 27" },
                    { -2, "Smith 17" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseAssignment",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 1045, -2 });

            migrationBuilder.DeleteData(
                table: "CourseAssignment",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 1050, -4 });

            migrationBuilder.DeleteData(
                table: "CourseAssignment",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 2021, -1 });

            migrationBuilder.DeleteData(
                table: "CourseAssignment",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 2042, -1 });

            migrationBuilder.DeleteData(
                table: "CourseAssignment",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 3141, -3 });

            migrationBuilder.DeleteData(
                table: "CourseAssignment",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 4022, -5 });

            migrationBuilder.DeleteData(
                table: "CourseAssignment",
                keyColumns: new[] { "CourseID", "InstructorID" },
                keyValues: new object[] { 4041, -5 });

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "OfficeAssignment",
                keyColumn: "InstructorID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "OfficeAssignment",
                keyColumn: "InstructorID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "OfficeAssignment",
                keyColumn: "InstructorID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1045,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1050,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2021,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2042,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3141,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4022,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4041,
                column: "DepartmentID",
                value: 0);

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "ID", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carson", "Alexander" },
                    { 2, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meredith", "Alonso" },
                    { 3, new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arturo", "Anand" },
                    { 4, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gytis", "Barzdukas" },
                    { 5, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yan", "Li" },
                    { 6, new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peggy", "Justice" },
                    { 7, new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Norman" },
                    { 8, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nino", "Olivetto" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentID", "CourseID", "Grade", "StudentID" },
                values: new object[,]
                {
                    { 1, 1050, 0, 1 },
                    { 2, 4022, 2, 1 },
                    { 3, 4041, 1, 1 },
                    { 4, 1045, 1, 2 },
                    { 5, 3141, 4, 2 },
                    { 6, 2021, 4, 2 },
                    { 7, 1050, null, 3 },
                    { 8, 1050, null, 4 },
                    { 9, 4022, 4, 4 },
                    { 10, 4041, 2, 5 },
                    { 11, 1045, null, 6 },
                    { 12, 3141, 0, 7 }
                });
        }
    }
}
