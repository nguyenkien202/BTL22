function responsive() {
	var x = document.getElementById("header-bot");
	if (x.className === "header_bot") {
		x.className += "responsive";
	}
	else {
		x.className = "header_bot";
	}
}