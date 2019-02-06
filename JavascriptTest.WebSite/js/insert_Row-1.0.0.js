function insertRow() {
	let sampleTable = document.getElementById('sampleTable');
	let tbody = sampleTable.children[0];
	let index = tbody.children.length;
	let count = index + 1;

	let row = sampleTable.insertRow(index);
	let cell0 = row.insertCell(0);
	let cell1 = row.insertCell(1);

	cell0.innerHTML = 'Row' + count + ' cell1';
	cell1.innerHTML = 'Row' + count + ' cell2';
}