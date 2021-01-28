// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*
$('#Assignments').keyup(calculate);
$('#Quizzes').keyup(calculate);
$('#group').keyup(calculate);
$('#Exams').keyup(calculate);
$('#INTEX').keyup(calculate);*/


	$("#submitButton").click(function () {



		var numericGrade = $('#Assignments').val() * 0.5
			+ $('#group').val() * 0.1
			+ $("#Quizzes").val() * 0.1 + $("#Exams").val() * 0.2
			+ $("#INTEX").val() * 0.1;
		var letterGrade = "";
		//if statements to see which letter grade they get
		if (numericGrade >= 94) {
			letterGrade = "A";
		}
		else if (numericGrade >= 90) {
			letterGrade = "A-";
		}
		else if (numericGrade >= 87) {
			letterGrade = "B+";
		}
		else if (numericGrade >= 84) {
			letterGrade = "B";
		}
		else if (numericGrade >= 80) {
			letterGrade = "B-";
		}
		else if (numericGrade >= 77) {
			letterGrade = "C+";
		}
		else if (numericGrade >= 74) {
			letterGrade = "C";
		}
		else if (numericGrade >= 70) {
			letterGrade = "C-";
		}
		else if (numericGrade >= 67) {
			letterGrade = "D+";
		}
		else if (numericGrade >= 64) {
			letterGrade = "D";
		}
		else if (numericGrade >= 60) {
			letterGrade = "D-";
		}
		else {
			letterGrade = "E";
		}
		document.getElementById("numericGrade").innerHTML = numericGrade;
		document.getElementById("letterGrade").innerHTML = letterGrade;

	
	});




